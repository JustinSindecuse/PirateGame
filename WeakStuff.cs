using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeakStuff : MonoBehaviour
{
    public Animator animator;

    bool opCannon;
    private float health;
    float time;

    void Start()
    {
        opCannon = false;
        health = 2f;
        time = 0f;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {

        string name = hitInfo.gameObject.name;
        Debug.Log("name: " + name);
        if (name == "Pirate")
        {
            opCannon = true;
            time = 0f;
        }
        if (name == "cannonBallSprite(Clone)" || name == "fin_2(Clone)")
        {
            health--;
            animator.SetFloat("health", health);
        }
    }

    //Add "if (input.getbuttondown"fire") shoot();
    void Update()
    {

        if (opCannon == true)
        {
            //Debug.Log("operating cannon " + this.name);
            if (health < 2)
            {
                //increase time global variable
                time += Time.deltaTime;
                if (time > 3)
                {
                    health = 2;
                    time = 0;
                    animator.SetFloat("health", health);
                }

            }
            if (Input.GetKey("c"))
            {
                opCannon = false;
            }
        }
    }
}