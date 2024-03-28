using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    TimeManager timeManager;

    [SerializeField, Header("���Ԃ̃e�L�X�g")]
    Text timeText;

    [SerializeField, Header("�X�R�A�̃e�L�X�g")]
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
