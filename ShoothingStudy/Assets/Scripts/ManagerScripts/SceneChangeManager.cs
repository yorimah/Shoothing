using UnityEngine.SceneManagement;

public class SceneChangeManager

{
    public static void TitleSceneLoad()
    {
        SceneManager.LoadScene("TitleScene");
        ScoreManager.AddScore(-9999);
    }

    public static void GameSceneLoad()
    {
        SceneManager.LoadScene("GameScene");
    }
}
