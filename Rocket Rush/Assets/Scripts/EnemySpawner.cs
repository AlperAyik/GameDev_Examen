using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1f, 2f);
    }

    void SpawnEnemy()
    {
        float randomX = Random.Range(-8f, 8f);

        Vector2 spawnPosition = new Vector2(randomX, 6f);

        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
}