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

    // ‚»‚ê‚¼‚êSerializeField‚ÅŒ©‚¦‚é‚æ‚¤‚É•Ê‚Ì•Ï”‚É’u‚«Š·‚¦‚Ä‚¨‚è‚Ü‚·
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
