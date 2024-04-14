using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : IPlayerInputable
{
    public Vector2 inputMove { get; set; }

    public bool isShot { get; set; }

    public void InputUpdate()
    {
        int moveX, moveY;

        if (Input.GetKey(KeyCode.UpArrow))
        {

            moveY = 1;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {

            moveY = -1;
        }
        else
        {
            moveY = 0;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {

            moveX = 1;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {

            moveX = -1;
        }
        else
        {
            moveX = 0;
        }

        inputMove = new Vector2(moveX, moveY);

        if (Input.GetKey(KeyCode.Z))
        {
            isShot = true;
        }
        else
        {
            isShot = false;
        }
    }
}
