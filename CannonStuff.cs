using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonStuff : MonoBehaviour
{
    public Transform firePoint;
    public GameObject cannonBallPrefab;
    public Animator animator;
    public Sprite DamagedCannon;
    public Sprite Cannon;
    public float speed;

    bool opCannon;
    public bool hit;
    float time;
    float cannonTimer;
    bool allowFire;
    float fireSpeed = 2;
    float waitTilNextFire;
   

    void Start()
    {
        opCannon = false;
        hit = false;
        time = 0;
        cannonTimer = 0;
        allowFire = true;
    }

    void OnCollisionEnter2D(Collision2D dataFromCollision)
    {
        
        string name = dataFromCollision.gameObject.name;
       // Debug.Log("name: " + name);
        if (name == "Pirate")
        {
            opCannon = true;
        }
        if (name == "cannonBallSprite(Clone)" || name == "fin_2(Clone)")
        {

            hit = true;
            animator.SetBool("Destroyed", true);
        }
    }
    
    //Add "if (input.getbuttondown"fire") shoot();
    void Update()
    {
        if (hit == true)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = DamagedCannon;
        }
        else
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Cannon;
        }
        if (opCannon == true)
        {
            //Debug.Log("operating cannon " + this.name);
            if (hit == true)
            {
                //increase time global variable
                time += Time.deltaTime;
                if (time > 3)
                {
                    hit = false;
                    time = 0;
                    animator.SetBool("Destroyed", false);
                }
            }
            else
            {
                //Add "if (input.getbuttondown"fire") shoot()
                //Debug.Log("Cannon: " + this.name + " is controlled.");
                //Shoot();
                //Debug.Log("waitTilNextFire" + waitTilNextFire);
                if (Input.GetKey("w")) //&& allowFire)
                {
                    if (waitTilNextFire <= 0)
                    {

                        Shoot();
                        waitTilNextFire = 1;
                    }

                    
                }
                waitTilNextFire -= Time.deltaTime * fireSpeed;
                
                float rotation = gameObject.transform.localRotation.z * Mathf.Rad2Deg;
                float lowerBound = 0;
                float upperBound = 0;
                if (this.name == "Cannon1")
                {
                    lowerBound = -40f;
                    upperBound = 0f;
                    Debug.Log("rotation: " + rotation);
                    Vector3 temp = new Vector3(0, 0, 0);
                    if (Input.GetKey("a"))
                    {
                        temp = new Vector3(0, 0, 1);
                        gameObject.transform.Rotate(temp, Space.Self);
                    }
                    else if (Input.GetKey("d"))
                    {
                        temp = new Vector3(0, 0, -1);
                        gameObject.transform.Rotate(temp, Space.Self);
                    }
                    if (rotation < lowerBound)
                    {
                        gameObject.transform.Rotate(new Vector3(0, 0, 1), Space.Self);
                    }
                    if (rotation > upperBound)
                    {
                        gameObject.transform.Rotate(new Vector3(0, 0, -1), Space.Self);
                    }
                }
                else if (this.name == "Cannon2")
                {
                    lowerBound = -57.2f;
                    upperBound = -40f;
                    Debug.Log("rotation: " + rotation);
                    Vector3 temp = new Vector3(0, 0, 0);
                    if (Input.GetKey("a"))
                    {
                        temp = new Vector3(0, 0, -1);
                        gameObject.transform.Rotate(temp, Space.Self);
                    }
                    else if (Input.GetKey("d"))
                    {
                        temp = new Vector3(0, 0, 1);
                        gameObject.transform.Rotate(temp, Space.Self);
                    }
                    if (rotation < lowerBound)
                    {
                        gameObject.transform.Rotate(new Vector3(0, 0, 1), Space.Self);
                    }
                    if (rotation > upperBound && rotation < 0)
                    {
                        gameObject.transform.Rotate(new Vector3(0, 0, -1), Space.Self);
                    }
                }
                else if (this.name == "Cannon3")
                {
                    lowerBound = -22.5f;
                    upperBound = 22.5f;
                    if (Input.GetKey("a"))
                    {
                        Vector3 temp = new Vector3(0, 0, 1);
                        gameObject.transform.Rotate(temp, Space.Self);
                    }
                    else if (Input.GetKey("d"))
                    {
                        Vector3 temp = new Vector3(0, 0, -1);
                        gameObject.transform.Rotate(temp, Space.Self);
                    }
                    if (rotation < lowerBound) gameObject.transform.Rotate(new Vector3(0, 0, lowerBound - rotation));
                    if (rotation > upperBound) gameObject.transform.Rotate(new Vector3(0, 0, upperBound - rotation));

                }
                else if (this.name == "Cannon4")
                {
                    lowerBound = 53f;
                    upperBound = -53f;
                    Debug.Log("rotation: " + rotation);
                    Vector3 temp = new Vector3(0, 0, 0);
                    if (Input.GetKey("a"))
                    {
                        temp = new Vector3(0, 0, -1);
                        gameObject.transform.Rotate(temp, Space.Self);
                    }
                    else if (Input.GetKey("d"))
                    {
                        temp = new Vector3(0, 0, 1);
                        gameObject.transform.Rotate(temp, Space.Self);
                    }
                    if (rotation < lowerBound && rotation > 0)
                    {
                        gameObject.transform.Rotate(new Vector3(0, 0, 1), Space.Self);
                    }
                    if(rotation > upperBound && rotation < 0)
                    {
                        gameObject.transform.Rotate(new Vector3(0, 0, -1), Space.Self);
                    }

                }
                else if (this.name == "Cannon5")
                {
                    if (Input.GetKey("a"))
                    {
                        Vector3 temp = new Vector3(0, 0, 1);
                        gameObject.transform.Rotate(temp, Space.Self);
                    }
                    else if (Input.GetKey("d"))
                    {
                        Vector3 temp = new Vector3(0, 0, -1);
                        gameObject.transform.Rotate(temp, Space.Self);
                    }
                    lowerBound = 5f;
                    upperBound = 56f;
                    if (rotation < lowerBound) gameObject.transform.Rotate(new Vector3(0, 0, lowerBound - rotation));
                    if (rotation > upperBound) gameObject.transform.Rotate(new Vector3(0, 0, upperBound - rotation));
                }
                //Debug.Log("rotation is " + rotation);
              
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
        //allowFire = false;
        Instantiate(cannonBallPrefab, firePoint.position, firePoint.rotation);
        //yield return new WaitForSeconds(1);
        //allowFire = true;
    }
}
