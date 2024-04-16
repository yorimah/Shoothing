using System;
using System.Collections.Generic;
using UnityEngine;

public static class ProjectInitializer
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Initialize()
    {
        Locator.Register<IMoveDirectionSetable, UniversalMove>();

        // �v���C���[�f�[�^�A�P��C���X�^���X
        Locator.Register<IPlayerData>(new PlayerData());

        // �v���C���[�֘A
        Locator.Register<IPlayerInputable, PlayerInput>();
        Locator.Register<IMoveable, PlayerMove>();
    }
}
