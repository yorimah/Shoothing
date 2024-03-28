using UnityEngine;

public interface IAttackable
{
    public int attackPower { get; set; }

    public int attackLayer { get; set; }

    public void Attack(GameObject collision);
}
