using UnityEngine;
using TMPro;

public class HealthManager : MonoBehaviour
{
    public TextMeshProUGUI healthText;
    public float health = 100;


    public void HealthBar(){
        healthText.text = "Health: " + Mathf.FloorToInt(health);
    }
    public void TakeHealth() {
        if(health > 11) {
            health -= 10;
            healthText.text = "Health: " + Mathf.FloorToInt(health);   
        } else {
            FindObjectOfType<GameManager>().GameOver();
        }
    }

    public void TakeHealth2(){
        if(health > 21) {
            health -= 20;
            healthText.text = "Health: " + Mathf.FloorToInt(health);   
        } else {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
    public void AddHealth(){
        health += 20;
        healthText.text = "Health: " + Mathf.FloorToInt(health);
    }
}