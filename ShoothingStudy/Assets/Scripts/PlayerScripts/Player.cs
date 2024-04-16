using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IDamageable
{
    IPlayerInputable iPI;
    // IShotable iShot;
    IMoveable iMove;
    IPlayerData iPD;

    public int hp { get; set; } = 3;
    public int defenceLayer { get; set; } = 1;

    [SerializeField]
    GameObject bullet;

    public void TakeDamage(int damage)
    {
        hp -= damage;
        if (hp <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        // ゲームオーバー
        //GameSceneManager.SceneChange();
    }

    void Start()
    {
        iPI = Locator.Resolve<IPlayerInputable>();
        //iShot = Locator.Resolve<IShotable>();
        iMove = Locator.Resolve<IMoveable>();
        iPD = Locator.Resolve<IPlayerData>();

        // iShot.bullet = this.bullet;

        hp = 3;
        defenceLayer = 1;
    }

    void Update()
    {
        iPD.PlayerHP = hp;
        iPD.PlayerPosition = new Vector2(transform.position.x, transform.position.y);

        iPI.InputUpdate();

        iMove.Move(iPI.inputMove, transform);

        if (iPI.isShot)
        {
            Debug.Log("うっちゃうよーん");
            // iShot.Shot(Vector2.up);
        }
    }


}
