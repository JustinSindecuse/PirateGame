using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonStuff : MonoBehaviour
{
    bool opCannon;
    bool hit;
    int time;

    void Start()
    {
        opCannon = false;
        hit = false;
        time = 0;
    }

    void OnCollisionEnter2D(Collision2D dataFromCollision)
    {
        Debug.Log("OnCollisionEnter2D");
        string name = dataFromCollision.gameObject.name;
        if(name == "Pirate")
        {
            opCannon = true;
        }
        if(name == "cannonBall")
        {
            hit = true;
        }
    }

    void Update()
    {
    if (opCannon == true)
    {
        if (hit == true)
        {
            //increase time global variable
            time += Time.deltaTime;
            if (time > 4000)
            {
                hit = false;
                time = 0;
            }

        }
        else
        {
            if (Input.GetKey("a"))
            {
                Vector3 temp = new Vector3(0, 0, 1);
                gameObject.transform.Rotate(temp, Space.Self);
            }
            else if(Input.GetKey("d")) {
            Vector3 temp = new Vector3(0, 0, -1);
            gameObject.transform.Rotate(temp, Space.Self);
            }
            float rotation = gameObject.transform.localRotation.z * Mathf.Rad2Deg;
            if(this.name == "Cannon5")
            {
                Debug.Log("cannon 5");
                if(rotation < 30)
                {
                    gameObject.transform.Rotate(new Vector3(0, 0, 30 - rotation));
                }
            }
        }
    }  
    }
}
