using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonStuff : MonoBehaviour
{
    bool opCannon;
    string objName;

    void Start()
    {
        opCannon = false;
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
        
    }

    void Update()
    {
        if (opCannon == true)
        {
            //Rotating and firing cannon
            if (Input.GetKey("a"))
            {
                Vector3 temp = new Vector3(0, 0, 3);
                gameObject.transform.Rotate(temp, Space.Self);
            }
        }
    }
}
