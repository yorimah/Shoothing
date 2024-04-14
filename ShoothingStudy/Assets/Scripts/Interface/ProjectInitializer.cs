using System;
using System.Collections.Generic;
using UnityEngine;

public static class ProjectInitializer
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Initialize()
    {
        Locator.Register<IMoveDirectionSetable>(new UniversalMove());

        

        // �v���C���[�֘A
        Locator.Register<IPlayerInputable, PlayerInput>();
        Locator.Register<IMoveable, PlayerMove>();
    }
}
