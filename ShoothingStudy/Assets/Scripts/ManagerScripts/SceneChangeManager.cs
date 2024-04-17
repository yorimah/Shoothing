using UnityEngine.SceneManagement;

public class SceneChangeManager

{
    public static void TitleSceneLoad()
    {
        SceneManager.LoadScene("TitleScene");
    }

    static void GameSceneLoad()
    {
        SceneManager.LoadScene("GameScene");
    }
}
