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

    }

    void Update()
    {
        if (opCannon == true)
        {
            if (!hit)
            {
                Vector3 temp = new Vector3(0, 0, 1);
                float rot = gameObject.transform.localRotation.z;
                if(objName == "Cannon1") {
                  if(rot > 359) temp = new Vector3(0, 0, 0);
                }
                gameObject.transform.Rotate(temp, Space.Self);
            }
            else if(Input.GetKey("d")) {
              Vector3 temp = new Vector3(0, 0, -1);
              float rot = gameObject.transform.localRotation.z;
              if(objName == "Cannon1") {
                if(rot < 275) temp = new Vector3(0, 0, 0);
              }
              gameObject.transform.Rotate(temp, Space.Self);
            }
        }
    }
}
