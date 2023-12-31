using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public HealthBar healthBar;

    [SerializeField] private Text scoreText;
    public static int score = 0;
    public int maxHealth = 3;
    public int currentHealth;


    public SoundManager soundManager;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText.text = "Score: " + score;
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (score > PlayerPrefs.GetInt("highScore"))
        {
            PlayerPrefs.SetInt("highScore", score);
        }
    }

    public void AddLives(int value)
    {
        currentHealth += value;
        healthBar.SetHealth(currentHealth);

        if (currentHealth <= 0)
        {
            SceneManager.LoadScene("GameOverMenu");
            Debug.Log("Game Over!");
            currentHealth = 0;
            //Time.timeScale = 0;
        }
        Debug.Log("Lives = " + currentHealth);
    }

    public void AddScore(int value)
    {
        score += value;
        scoreText.text  = "Score: " + score;
    }

   
}
