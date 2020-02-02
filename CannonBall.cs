using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBall : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.up * speed;
    }


    //note: all enemies must have a collider2d component of some sort; box, circle, or whatever.
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log(hitInfo.name);
        //Destroy(gameObject);
    }

    // Update is called once per frame
    //Destroy the cannonballs if they're farther than 3x the camera length (~+/- 30)
    void Update()
    {
     //   if (rb.posx > 30 || posx < -30 || posy > 30 || posy < -30)
     //       Destroy(gameObject);
    }
}
