using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    [SerializeField] public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        ScoreDisplay();
    }

    public void PlayAgainButton()
    {
        SceneManager.LoadScene("GameMenu");
    }

    private void ScoreDisplay()
    {
        scoreText.text = "Your Score: " + GameManager.score;
    }
}
