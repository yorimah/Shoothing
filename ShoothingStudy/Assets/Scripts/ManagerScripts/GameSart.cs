using UnityEngine;

public class GameSart : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            SceneChangeManager.GameSceneLoad();
        }
    }
}
