using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    // hello
    public GameObject PowerUpPrefab;

    void Start()
    {
        InvokeRepeating("SpawnPowerUp", 5f, 10f);
        // Iedere 5-10 seconden een powerup spawnen
        // Ook een powerup die alles asteroids vertraagt en minder maakt
    }

    void SpawnPowerUp()
    {
        float randomX = Random.Range(-8f, 8f);

        Vector2 spawnPosition = new Vector2(randomX, 6f);

        Instantiate(PowerUpPrefab, spawnPosition, Quaternion.identity);
    }
}
