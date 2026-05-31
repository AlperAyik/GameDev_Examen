using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public float score;

    void Update()
    {
        score += Time.deltaTime * 10f;
        scoreText.text = "Score: " + Mathf.FloorToInt(score);
    }
}
