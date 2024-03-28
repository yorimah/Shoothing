using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour, IAttackable
{
    IMoveDirectionSetable mds;

    [SerializeField]
    int _attackPower;

    [SerializeField]
    int _attackLayer;

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

    }

    void Start()
    {
        mds = Locator.Resolve<IMoveDirectionSetable>();
    }
}
