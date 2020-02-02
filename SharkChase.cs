using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkChase : MonoBehaviour
{
    public float speed;

    private Vector2 target;
    int randY;

    // Start is called before the first frame update
    void Start()
    {
        randY = Random.Range(1, 5);
        if (transform.position.y > 0f)
        {
            if(randY == 1)
            {
                target = new Vector2(-3.3f, 1.87f);
            }
            else if(randY == 2)
            {
                target = new Vector2(-.9f, 1.33f);
            }
            else if(randY == 3)
            {
                target = new Vector2(.48f, 1.52f);
            }
            else if(randY == 4)
            {
                target = new Vector2(2.01f, 1.43f);
            }
        }
        else
        {
            if (randY == 1)
            {
                target = new Vector2(-3.3f, -1.13f);
            }
            else if (randY == 2)
            {
                target = new Vector2(-.93f, -1.3f);
            }
            else if (randY == 3)
            {
                target = new Vector2(.48f, -1.3f);
            }
            else if (randY == 4)
            {
                target = new Vector2(2f, -.72f);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }
}
