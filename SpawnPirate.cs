using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPirate : MonoBehaviour
{
    public GameObject enemy;
    public float spawnRate;

    float randX;
    Vector2 whereToSpawn;
    float nextSpawn;
    int randY;
    float yPos;

    // Start is called before the first frame update
    void Start()
    {
        yPos = 3.52f;
        nextSpawn = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randX = -14.38f;
            randY = Random.Range(1, 3);
            if(randY == 1)
            {
                yPos = 3.52f;
            }
            if(randY == 2)
            {
                yPos = -3.42f;
            }
            Vector2 whereToSpawn1 = new Vector2(randX, yPos);
            Instantiate(enemy, whereToSpawn1, Quaternion.identity);
        }
    }
}
