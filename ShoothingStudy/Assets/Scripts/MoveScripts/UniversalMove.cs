using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniversalMove : IMoveDirectionSetable 
{ 
    public Vector2 moveDirection { get; set; }

    public int moveSpeed { get; set; }

    public void Move(Vector2 input, Transform tf)
    {
        moveDirection = input;
        tf.position += new Vector3(moveSpeed * moveDirection.x, moveSpeed * moveDirection.y).normalized;

    }
}
