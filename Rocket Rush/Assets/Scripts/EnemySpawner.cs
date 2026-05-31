using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject enemy2Prefab;

    private bool speedIncreased = false;
    private bool spawnEnemy2 = false;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1f, 2f);
    }

    void Update()
    {
        if(FindObjectOfType<ScoreManager>().score > 100 && !speedIncreased)
        {
            speedIncreased = true;
            CancelInvoke("SpawnEnemy");
            InvokeRepeating("SpawnEnemy", 1f, 1f);
        } 
        if(FindObjectOfType<ScoreManager>().score > 500 && !spawnEnemy2)
        {
            spawnEnemy2 = true;
            InvokeRepeating("SpawnEnemy2", 1f, 0.5f);
        }
    }

    void SpawnEnemy()
    {
        float randomX = Random.Range(-8f, 8f);

        Vector2 spawnPosition = new Vector2(randomX, 6f);

        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }

    void SpawnEnemy2()
    {
        float randomX = Random.Range(-8f, 8f);

        Vector2 spawnPosition = new Vector2(randomX, 6f);

        Instantiate(enemy2Prefab, spawnPosition, Quaternion.identity);
    }
}