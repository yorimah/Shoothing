using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniversalShot : MonoBehaviour
{
    public GameObject bullet;

    public void Shot(Vector2 direction, Transform tf)
    {
        Instantiate(bullet, tf.position, Quaternion.identity);
        bullet.GetComponent<Bullet>().direction = direction;

    }
}
