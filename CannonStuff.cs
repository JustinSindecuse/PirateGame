using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonStuff : MonoBehaviour
{
    bool opCannon;
    string objName;
    bool hit;

    void Start()
    {
        opCannon = false;
        hit = false;
    }

    void OnCollisionEnter2D(Collision2D dataFromCollision)
    {
        Debug.Log("OnCollisionEnter2D");
        string name = dataFromCollision.gameObject.name;
        if(name == "Pirate")
        {
            objName = name;
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
            if (!hit)
            {
                //Rotating and firing cannon
                if (Input.GetKey("a"))
                {
                    Vector3 temp = new Vector3(0, 0, 1);
                    gameObject.transform.Rotate(temp, Space.Self);
                }
            }
        }
    }
}
