using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    public int lives = 3;
    // public int ammo
    
    public GameObject barrel1;
    public GameObject barrel2;
    public GameObject fireball;
    public Rigidbody2D rb;

    [SerializeField]
    private int score;

    private UIManager uiManager;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();

        if (uiManager == null) {
            Debug.Log("uimanger is null. You should probably fix that....");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // movement
        float x = Input.GetAxisRaw("Horizontal") * moveSpeed;
        rb.velocity = new Vector2(x, 0);
        //transform.Translate(new Vector3(x, 0, 0));

        if (Input.GetButtonDown("Fire1")) {
            Shoot();
        }  
    }

    public void Shoot() {
        // Debug.Log("Shoot");
        Instantiate(fireball, barrel1.transform);
        Instantiate(fireball, barrel2.transform);
    }

    void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.tag == "enemy") {
            lives -= 1;
            Destroy(this.gameObject);
            // death particle/animations
            // wait for seconds or for key press
            // respawn method?
        }
    }

    public void AddScore() {
        score += 10;
        uiManager.UpdateScore(score);
    }
}
