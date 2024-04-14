using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour, IAttackable
{
    IMoveDirectionSetable mds;

    // 弾丸の飛んでいく方向の指定です、生成する際に-1~1の範囲で設定してください
    public Vector2 direction = Vector2.zero;
    Vector2 startPos;

    // 弾速です、生成する際に設定した方がいいかもです
    public int speed = 10;

    [SerializeField]
    int _attackPower = 1;
    [SerializeField]
    int _attackLayer = 0;

    // それぞれSerializeFieldで見えるように別の変数に置き換えております
    public int attackPower
    {
        get { return _attackPower; }
        set { _attackPower = value; }
    }
    public int attackLayer
    {
        get { return _attackLayer; }
        set { _attackLayer = value; }
    }

    public void Attack(GameObject collision)
    {
        if (collision.TryGetComponent<IDamageable>(out IDamageable dmg))
        {
            if (dmg.defenceLayer != attackLayer)
            {
                dmg.TakeDamage(attackPower);
                Destroy(this.gameObject);
            }
        }
    }

    void Start()
    {
        mds = Locator.Resolve<IMoveDirectionSetable>();
        mds.moveSpeed = speed;

        startPos = transform.position;
    }

    void Update()
    {
        mds.moveDirection = direction;
        mds.Move(mds.moveDirection,startPos, transform);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Attack(collision.gameObject);
    }
}
