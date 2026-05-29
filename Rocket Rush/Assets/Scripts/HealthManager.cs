using UnityEngine;
using TMPro;

public class HealthManager : MonoBehaviour
{
    public TextMeshProUGUI healthText;
    private float health = 100;

    public void Health()
    {
        health -= 10;
        healthText.text = "Health: " + Mathf.FloorToInt(health);
    }
}
