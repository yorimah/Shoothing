public class ScoreManager
{
    private static int score = 0;
    public static void AddScore(int _score)
    {
        score += _score;
        if (score < 0)
        {
            score = 0;
        }
    }

    public static int GetScore()
    {
        return score;
    }
}
