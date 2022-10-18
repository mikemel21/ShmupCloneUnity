using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileScript : MonoBehaviour
{
    public float speed = 40.0f;
    public int damage = 5;

    // time before bullet despawns
    public float timeBeforeDie = 3.0f;
    private float elapsedTime;

    // Start is called before the first frame update
    void Start()
    {
        elapsedTime = 0.0f;

    }

    // Update is called once per frame
    void Update()
    {
        // shoots the projectile
        transform.Translate(new Vector3(0, 1 * speed * Time.deltaTime, 0));

        //timer for despawning projectile
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= timeBeforeDie)
            Destroy(gameObject);
    }

    /*
    private IEnumerator BulletTime() {
    }
    */
}
