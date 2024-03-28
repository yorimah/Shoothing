using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    TimeManager timeManager;

    [SerializeField, Header("時間のテキスト")]
    Text timeText;

    [SerializeField, Header("スコアのテキスト")]
    Text scoreText;
    private void Start()
    {
        timeManager = new TimeManager();
        timeManager.TimeUpdate();
    }

    private void Update()
    {
        timeManager.TimeUpdate();

        DisplayUI();
    }

    private void DisplayUI()
    {
        timeText.text = timeManager.time.ToString("f0");
        scoreText.text = ScoreManager.GetScore().ToString();
    }
}
