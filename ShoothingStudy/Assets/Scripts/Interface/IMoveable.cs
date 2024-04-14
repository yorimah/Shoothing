using UnityEngine;

public interface IMoveable
{
    public int moveSpeed { get; set; }

    public void Move(Vector2 input, Transform transform);
}
