using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataTest : MonoBehaviour
{
    IPlayerData iPD;

    void Start()
    {
        iPD = Locator.Resolve<IPlayerData>();
    }

    void Update()
    {
        Debug.Log(iPD.PlayerPosition);
    }
}
