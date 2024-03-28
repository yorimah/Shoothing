using UnityEngine;

public interface IShotable
{
    public GameObject bullet { get; set; }

    public void Shot(Vector2 direction);
}
