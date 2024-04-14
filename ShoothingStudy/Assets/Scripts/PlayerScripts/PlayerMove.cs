using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : IMoveable
{
    public int moveSpeed { get; set; } = 10;

    public void Move(Vector2 input, Transform transform)
    {
        Vector2 pos = transform.position;
        pos += input * moveSpeed * Time.deltaTime;
        transform.position = pos;
    }
}
