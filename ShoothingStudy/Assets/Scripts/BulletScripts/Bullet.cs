using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour, IAttackable
{
    IMoveDirectionSetable mds;

    // �e�ۂ̔��ł��������̎w��ł��A��������ۂ�-1~1�͈̔͂Őݒ肵�Ă�������
    public Vector2 direction = Vector2.zero;
    Vector2 startPos;

    // �e���ł��A��������ۂɐݒ肵���������������ł�
    public int speed = 10;

    [SerializeField]
    int _attackPower = 1;
    [SerializeField]
    int _attackLayer = 0;

    // ���ꂼ��SerializeField�Ō�����悤�ɕʂ̕ϐ��ɒu�������Ă���܂�
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
