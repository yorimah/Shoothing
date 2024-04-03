using UnityEngine.SceneManagement;

public class SceneChangeManager

{
    static void TitleSceneLoad()
    {
        SceneManager.LoadScene("TitleScene");
    }

    static void GameSceneLoad()
    {
        SceneManager.LoadScene("GameScene");
    }
}
