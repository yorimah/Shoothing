using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : IPlayerData
{
    public int PlayerHP { get; set; } = 3;

    public Vector2 PlayerPosition { get; set; } = Vector2.zero;
}
