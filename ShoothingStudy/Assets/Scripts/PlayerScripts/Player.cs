using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IDamageable
{
    IPlayerInputable iPI;
    IMoveable iMove;
    IPlayerData iPD;

    [SerializeField]
    UniversalShot us;

    public int hp { get; set; } = 3;
    public int defenceLayer { get; set; } = 1;


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
        Debug.Log("プレイヤー死亡");
        // ゲームオーバー
        //GameSceneManager.SceneChange();

        Destroy(gameObject);
    }

    void Start()
    {
        iPI = Locator.Resolve<IPlayerInputable>();
        iMove = Locator.Resolve<IMoveable>();
        iPD = Locator.Resolve<IPlayerData>();


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
            us.Shot(new Vector2(transform.position.x, transform.position.y + 10), transform);

            iPI.isShot = false;
        }
    }


}
