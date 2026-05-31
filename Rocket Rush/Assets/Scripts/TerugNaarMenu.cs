using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TerugNaarMenu : MonoBehaviour
{
    public ScoreManager scoreManager;
    public void TerugMenu()
    {
        scoreManager = FindFirstObjectByType<ScoreManager>();
        
        int currentHighScore = PlayerPrefs.GetInt("HighScore", 0);

        if (scoreManager.score > currentHighScore)
        {
            PlayerPrefs.SetInt("HighScore", Mathf.FloorToInt(scoreManager.score));
            PlayerPrefs.Save();
        }

        SceneManager.LoadScene("MainMenu");
    }
}