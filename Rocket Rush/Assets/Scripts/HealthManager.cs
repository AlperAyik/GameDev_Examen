using UnityEngine;
using TMPro;

public class HealthManager : MonoBehaviour
{
    public TextMeshProUGUI healthText;
    public float health = 100;

    public void Health(){
        if(health > 10) {
            healthText.text = "Health: " + Mathf.FloorToInt(health);   
        } else {
            FindObjectOfType<GameManager>().GameOver();
        }
        Debug.Log("Health: " + health);
        health -= 10; 
    }
}
