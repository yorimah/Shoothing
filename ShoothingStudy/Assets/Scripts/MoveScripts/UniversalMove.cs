using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniversalMove : IMoveDirectionSetable 
{ 
    public Vector2 moveDirection { get; set; }

    public int moveSpeed { get; set; }

    /// <summary>
    /// (�������̑���̍��W�A�������̎����̍��W�A������transform)
    /// </summary>

    public void Move(Vector2 plPos, Vector2 startPos,Transform tf)
    {
        
        moveDirection = new Vector2(plPos.x - startPos.x, plPos.y - startPos.y);
        tf.position += new Vector3(moveDirection.x, moveDirection.y).normalized * moveSpeed * Time.deltaTime;


    }
}
