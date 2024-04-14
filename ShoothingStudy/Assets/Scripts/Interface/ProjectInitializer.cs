using System;
using System.Collections.Generic;
using UnityEngine;

public static class ProjectInitializer
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Initialize()
    {
        Locator.Register<IMoveDirectionSetable>(new UniversalMove());

        

        // プレイヤー関連
        Locator.Register<IPlayerInputable, PlayerInput>();
        Locator.Register<IMoveable, PlayerMove>();
    }
}
