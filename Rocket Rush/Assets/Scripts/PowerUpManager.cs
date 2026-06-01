using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    public GameObject PowerUpPrefab;
    void Start()
    {
        InvokeRepeating("SpawnPowerUp", 5f, 10f);
    }

    void SpawnPowerUp()
    {
        if(FindAnyObjectByType<HealthManager>().health <= 80)
        {
            float randomX = Random.Range(-8f, 8f);

            Vector2 spawnPosition = new Vector2(randomX, 6f);

            Instantiate(PowerUpPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
