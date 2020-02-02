using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonStuff : MonoBehaviour
{
    public Transform firePoint;
    public GameObject cannonBallPrefab;
    
    bool opCannon;
    bool hit;
    float time;

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
        if (name == "Pirate")
        {
            opCannon = true;
        }
        if (name == "cannonBall")
        {
            hit = true;
        }
    }

    //Add "if (input.getbuttondown"fire") shoot();
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
                //Add "if (input.getbuttondown"fire") shoot()
                if (Input.GetKey("w"))
                {
                    Shoot();
                }
                else if (Input.GetKey("a"))
                {
                    Vector3 temp = new Vector3(0, 0, 1);
                    gameObject.transform.Rotate(temp, Space.Self);
                }
                else if (Input.GetKey("d"))
                {
                    Vector3 temp = new Vector3(0, 0, -1);
                    gameObject.transform.Rotate(temp, Space.Self);
                }
                float rotation = gameObject.transform.localRotation.z * Mathf.Rad2Deg;
                int lowerBound = 0;
                int upperBound = 0;
                if (this.name == "Cannon1")
                {
                    lowerBound = 275;
                    upperBound = 355;
                }
                else if (this.name == "Cannon2")
                {
                    lowerBound = 185;
                    upperBound = 275;
                }
                else if (this.name == "Cannon3")
                {
                    lowerBound = -45;
                    upperBound = 45;
                }
                else if (this.name == "Cannon4")
                {
                    lowerBound = 135;
                    upperBound = 225;
                }
                else if (this.name == "Cannon5")
                {
                    lowerBound = 0;
                    upperBound = 180;
                }
                if (rotation < lowerBound) gameObject.transform.Rotate(new Vector3(0, 0, lowerBound - rotation));
                if (rotation > upperBound) gameObject.transform.Rotate(new Vector3(0, 0, rotation - upperBound));
            }
            if (Input.GetKey("c"))
            {
                opCannon = false;
            }
        }
    }

    void Shoot()
    {
        //shooting logic
        Instantiate(cannonBallPrefab, firePoint.position, firePoint.rotation);
    }
}
