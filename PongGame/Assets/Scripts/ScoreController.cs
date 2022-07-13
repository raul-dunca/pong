using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour
{
    private int ScorePlayer1 = 0;
    private int ScorePlayer2 = 0;

    public GameObject ScoreTextPlayer1;
    public GameObject ScoreTextPlayer2;
    public int GoalToWin;
    public void GoalPlayer1()
    {
        this.ScorePlayer1++;
    }
    public void GoalPlayer2()
    {
        this.ScorePlayer2++;
    }
    private void FixedUpdate()
    {
        Text uiScorePlayer1 = this.ScoreTextPlayer1.GetComponent<Text>();
        uiScorePlayer1.text = this.ScorePlayer1.ToString();

        Text uiScorePlayer2 = this.ScoreTextPlayer2.GetComponent<Text>();
        uiScorePlayer2.text = this.ScorePlayer2.ToString();
    }
    void Update()
    {
        if (this.ScorePlayer1 >= this.GoalToWin || this.ScorePlayer2 >= this.GoalToWin)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
