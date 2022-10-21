using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController : MonoBehaviour
{
    public float minSpeed = 5.0f;
    public float maxSpeed = 9.0f;
    public float speed;
    public float health = 10.0f;
    public projectileScript pscript;
    public GameObject projectile;

    private playerController player;

    void Start () {
        speed = Random.Range(minSpeed, maxSpeed);
        player = GameObject.Find("playerShip").GetComponent<playerController>();
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(0, -speed * Time.deltaTime));

        if (health <= 0) {
            Destroy(gameObject);

            // increment score
            if (player != null) {
                player.AddScore();
            }
            // death animation/particle
            // death sound
        }
    }

    void OnTriggerEnter2D (Collider2D col) {
        if (col.gameObject.tag == "Projectile") {
            health -= pscript.damage;
            Destroy(col.gameObject);
        }
        if (col.gameObject) {

        }
    }
}
