using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverMenu : MonoBehaviour
{
   
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private TMP_Text highScoreText;

    // Start is called before the first frame update
    void Start()
    {
        ScoreDisplay();
        HighScoreDisplay();
    }

    public void PlayAgainButton()
    {
        SceneManager.LoadScene("GameMenu");
    }

    private void ScoreDisplay()
    {
        scoreText.text = "Your Score: " + GameManager.score;
    }

    public void HighScoreDisplay()
    {
        highScoreText.text = "High Score: " + PlayerPrefs.GetInt("highScore").ToString();
    }
}
