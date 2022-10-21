using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class combatManager : MonoBehaviour
{
    public enemyController[] enemies;
    public GameObject enemy;
    public enemyController en;
    public float elapsedTime = 0.0f;
    public float difficultyTime = 15.0f;

    // Update is called once per frame
    void Update()
    {
            // Timer
            elapsedTime += Time.deltaTime;

            if (elapsedTime >= difficultyTime) {
                

                elapsedTime = 0;
            }
    }
}
