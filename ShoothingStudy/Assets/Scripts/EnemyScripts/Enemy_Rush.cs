using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Rush : MonoBehaviour , IDamegeable, IAttackable
{
    public int hp { get; set; }
    public int defenceLayer { get; set; }
    public int attackPower { get; set; }
    public int attackLayer { get; set; }

    void Start()
    {
        hp = 1;

        attackPower = 1;
    }

    void Update()
    {
        
    }
    public void TakeDamege(int damege)
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
