using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] enemies;
    public enemyController[] enemy;
    public float minX;
    public float maxX;

    public float spawnTime = 3.0f;
    public float spawnElapsedTime = 0.0f;
    public float diffElapsedTime = 0.0f;
    public float difficultyTime = 15.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // increment elapsed time by every second
        spawnElapsedTime += Time.deltaTime;
        diffElapsedTime += Time.deltaTime;

        if (spawnElapsedTime >= spawnTime) {
            spawnIt();
            spawnElapsedTime = 0.0f;
        }
        if (diffElapsedTime >= difficultyTime) {
            Difficulty();
            diffElapsedTime = 0;
        }
    }

    public void spawnIt () {
        // choose enemy
        GameObject enemySpawn = enemies[Random.Range(0, enemies.Length)];
        
        var spawnLoc = new Vector2(Random.Range(minX, maxX), this.transform.position.y);

        // spawn
        Instantiate(enemySpawn, spawnLoc, this.transform.rotation);

        // randomize the next spawn time
        spawnTime = Random.Range(1,4);
    }

    public void Difficulty() {
        //enemy[0].health *= 2;
    }
}
