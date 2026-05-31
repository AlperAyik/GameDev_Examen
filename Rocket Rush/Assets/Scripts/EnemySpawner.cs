using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    // public GameObject enemy2Prefab; maak nog een enemyPrefab aan die na 500 score of 1000 score ook begint te spawnen

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1f, 2f);
    }

    void SpawnEnemy()
    {
        if(FindObjectOfType<ScoreManager>().score > 100)
        {
            CancelInvoke("SpawnEnemy");
            InvokeRepeating("SpawnEnemy", 1f, 1f);
        } else if(FindObjectOfType<ScoreManager>().score > 500)
        {
            CancelInvoke("SpawnEnemy");
            InvokeRepeating("SpawnEnemy", 1f, 0.5f);
        }

        float randomX = Random.Range(-8f, 8f);

        Vector2 spawnPosition = new Vector2(randomX, 6f);

        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
}