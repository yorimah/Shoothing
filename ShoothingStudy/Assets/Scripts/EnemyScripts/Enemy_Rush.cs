using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Rush : MonoBehaviour , IDamageable, IAttackable
{
    UniversalMove um;

    public int hp { get; set; }
    public int defenceLayer { get; set; }
    public int attackPower { get; set; }
    public int attackLayer { get; set; }

    void Start()
    {
        um = new UniversalMove();
        um.moveSpeed = 1;
    }

    void Update()
    {
        um.Move(new Vector2(0,-1), transform);
    }
    public void TakeDamage(int damege)
    {

    }
    public void Attack(GameObject collision)
    {
        
    }


    public void Die()
    {
        Destroy(gameObject);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        Attack(collision.gameObject);
    }
}
