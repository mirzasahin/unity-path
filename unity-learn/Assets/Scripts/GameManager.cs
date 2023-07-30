using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    private int score = 0;
    private int lives = 3;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddLives(int value)
    {
        lives += value;

        if (lives <= 0)
        {
            SceneManager.LoadScene("GameOverMenu");
            Debug.Log("Game Over!");
            lives = 0;
            //Time.timeScale = 0;
        }
        Debug.Log("Lives = " + lives);
    }

    public void AddScore(int value)
    {
        score += value;
        Debug.Log("Score = " + score);
    }
}
