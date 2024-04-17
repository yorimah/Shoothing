using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    TimeManager timeManager;

    HPDispManager hpDispManager;

    [SerializeField, Header("���Ԃ̃e�L�X�g")]
    Text timeText;

    [SerializeField, Header("�X�R�A�̃e�L�X�g")]
    Text scoreText;
    [SerializeField, Header("PlayerHP�̃e�L�X�g")]
    Text PlayerHPText;
    private void Start()
    {
        timeManager = new TimeManager();
        timeManager.TimeUpdate();

        hpDispManager = new HPDispManager();
    }

    private void Update()
    {
        timeManager.TimeUpdate();

        DisplayUI();
    }

    private void DisplayUI()
    {
        timeText.text = "TIME " + timeManager.time.ToString("f0");
        scoreText.text = "SCORE\n" + ScoreManager.GetScore().ToString();
        PlayerHPText.text = "HP :" + hpDispManager.GetPlayerHP().ToString();
    }
}
