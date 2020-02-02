﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{

    public GameObject enemy;
    float randX;
    Vector2 whereToSpawn;
    public float spawnRate = 5f;
    float nextSpawn = 0.0f;

    void Start()
    {

    }


    void Update()
    {
        if(Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range (-7.5f,7.5f);
            whereToSpawn1 = new Vector2(randX, 4.5);
            whereToSpawn2 = new Vector2(randX, -4.5);
            Instantiate (enemy, whereToSpawn1, Quaternion.identity);
            Instantiate (enemy, whereToSpawn2, Quaternion.identity);
        }

    }
        

}
