using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMove : MonoBehaviour
{

    public float speed;
    private float yPos;

    private Vector2 target;
    // Start is called before the first frame update
    void Start()
    {
        yPos = transform.position.y;
        target = new Vector2(3.82f, yPos);
    }

    // Update is called once per frame
    void Update()
    {
        //decide if it needs to change target
        if(transform.position.x == 3.82f)
        {
            target = new Vector2(-4.28f, yPos);
        }
        if(transform.position.x == -4.28f)
        {
            target = new Vector2(3.82f, yPos);
        }
        //Move
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }
}
