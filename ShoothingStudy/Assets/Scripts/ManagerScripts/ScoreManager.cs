public class ScoreManager
{
    private static int score = 0;
    public static void AddScore(int _score)
    {
        score += _score;
    }    

    public static int GetScore()
    {
        return score;
    }
}
