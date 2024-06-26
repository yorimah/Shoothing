using UnityEngine;

public interface IMoveDirectionSetable
{
    public Vector2 moveDirection { get; set; }

    public int moveSpeed { get; set; }

    public void Move(Vector2 plPos ,Vector2 startPos, Transform tf);
}
