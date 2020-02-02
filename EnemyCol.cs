using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCol : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.name == "CannonBallSprite(Clone)") 
        {
            Destroy(gameObject);
        }
        if(hitInfo.name == "WeakPoint1" || hitInfo.name == "WeakPoint2" ||
            hitInfo.name == "WeakPoint3" || hitInfo.name == "WeakPoint4" || hitInfo.name == "WeakPoint5")
        {
            Destroy(gameObject);
        }
        if (hitInfo.name == "Cannon1" || hitInfo.name == "Cannon2" || hitInfo.name == "Cannon3" ||
        hitInfo.name == "Cannon4" || hitInfo.name == "Cannon5")
        {
            Destroy(gameObject);
        }
        if(hitInfo.name == "EnemyShip(Clone)")
        {
            Destroy(gameObject);
        }
    }
}
