using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Shot : MonoBehaviour, IDamageable, IAttackable
{
    IMoveDirectionSetable um;

    IPlayerData iPD;

    [SerializeField]UniversalShot uShot;

    Vector3 plPos;
    Vector3 startPos;

    [SerializeField]
    int _attackPower = 1;
    [SerializeField]
    int _attackLayer = 2;
    [SerializeField]
    int _defenceLayer = 2;

    // �ړ����x
    [SerializeField]
    int _moveSpeed;
    // �̗�
    [SerializeField]
    int _hp = 1;

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
    public int hp
    {
        get { return _hp; }
        set { _hp = value; }
    }
    public int defenceLayer
    {
        get { return _defenceLayer; }
        set { _defenceLayer = value; }
    }


    void Start()
    {
        um = Locator.Resolve<IMoveDirectionSetable>();
        um.moveSpeed = _moveSpeed;

        iPD = Locator.Resolve<IPlayerData>();

        startPos = transform.position;
        //plPos = GameObject.Find("Player").transform.position;
        plPos = iPD.PlayerPosition;

    }

    void Update()
    {

        um.Move(startPos + new Vector3(0, -1, 0), startPos, transform);

        if (Input.GetKeyDown(KeyCode.Z))
        {
            // ���Ƃ����W�v���C���[���W�擾
            plPos = iPD.PlayerPosition;
            uShot.Shot(plPos,transform);
        }

    }

    public void TakeDamage(int damage)
    {
        hp -= damage;
        if (hp <= 0)
        {
            Die();
        }
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


    public void Die()
    {
        Destroy(gameObject);
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        Attack(collision.gameObject);
    }
}
