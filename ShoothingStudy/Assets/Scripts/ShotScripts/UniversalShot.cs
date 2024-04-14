using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniversalShot : MonoBehaviour
{
    Bullet blt;
    public GameObject bullet;

    public void Shot(Vector2 direction, Transform tf)
    {
        Instantiate(bullet, tf);
        blt = bullet.GetComponent<Bullet>();

        blt.direction = direction;
    }
}
