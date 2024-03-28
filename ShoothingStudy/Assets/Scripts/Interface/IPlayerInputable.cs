using UnityEngine;

public interface IPlayerInputable
{
    public Vector2 inputMove { get; set; }

    public bool isShot { get; set; }

    public void PlayerInput();
}
