using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IDamageable
{
    IPlayerInputable iPI;
    IShotable iShot;
    IMoveable iMove;

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

    static int GetHP()
    {
        // 書き方わかんにゃーい
        // return hp;
        return 3;
    }

    static Vector2 GetPosition()
    {
        // 書き方わかんにゃーい
        // return transform.position;
        return Vector2.zero;
    }

    void Start()
    {
        iPI = Locator.Resolve<IPlayerInputable>();
        //iShot = Locator.Resolve<IShotable>();
        iMove = Locator.Resolve<IMoveable>();

        // iShot.bullet = this.bullet;

        hp = 3;
        defenceLayer = 1;
    }

    void Update()
    {
        iPI.InputUpdate();

        iMove.Move(iPI.inputMove, transform);

        if (iPI.isShot)
        {
            iShot.Shot(Vector2.up);
        }
    }


}
