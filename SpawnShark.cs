using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnShark : MonoBehaviour
{
    public GameObject enemy;
    public float spawnRate;

    float randX;
    float randX2;
    Vector2 whereToSpawn;
    float nextSpawn;

    void Start()
    {
        spawnRate = 15f;
        nextSpawn = 0.0f;
    }


    void Update()
    {
        if(Time.time > 45 && Time.time < 90)
        {
            spawnRate = 13f;
        }
        if(Time.time > 90 && Time.time < 135)
        {
            spawnRate = 11f;
        }
        if(Time.time > 135 && Time.time < 180)
        {
            spawnRate = 9f;
        }
        if(Time.time > 225 && Time.time < 270)
        {
            spawnRate = 7f;
        }
        if(Time.time > 270)
        {
            spawnRate = 5f;
        }
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(-7.5f, 7.5f);
            randX2 = Random.Range(-7.5f, 7.5f);
            Vector2 whereToSpawn1 = new Vector2(randX, 4.5f);
            Vector2 whereToSpawn2 = new Vector2(randX2, -4.5f);
            Instantiate(enemy, whereToSpawn1, Quaternion.identity);
            Instantiate(enemy, whereToSpawn2, Quaternion.identity);
        }

    }
}
