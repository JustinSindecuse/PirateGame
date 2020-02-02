using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PirateStuff : MonoBehaviour
{
    public Transform firepoint;
    public Transform firepoint2;
    public GameObject cannonBall;
    public float startTime;
    private float timeB;

    // Start is called before the first frame update
    void Start()
    {
        timeB = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(timeB <= 0)
        {
            Instantiate(cannonBall, firepoint.position, firepoint.rotation);
            Instantiate(cannonBall, firepoint2.position, firepoint2.rotation);
            timeB = startTime;
        }
        else
        {
            timeB -= Time.deltaTime;
        }
    }
}
