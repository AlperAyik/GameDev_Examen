using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject enemy2Prefab;
    public GameObject enemySpaceShipPrefab;

    private bool speedIncreased = false;
    private bool spawnEnemy2 = false;
    private bool SpawnSpaceShipBool = false;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1f, 1f);
    }

    void Update()
    {
        if (FindObjectOfType<ScoreManager>().score > 100 && !speedIncreased)
        {
            speedIncreased = true;
            CancelInvoke("SpawnEnemy");
            InvokeRepeating("SpawnEnemy", 1f, 0.5f);
        }

        if (FindObjectOfType<ScoreManager>().score > 500 && !spawnEnemy2)
        {
            spawnEnemy2 = true;
            InvokeRepeating("SpawnEnemy2", 1f, 0.5f);
        }

        if (FindObjectOfType<ScoreManager>().score > 1000 && !SpawnSpaceShipBool)
        {
            SpawnSpaceShipBool = true;

            CancelInvoke("SpawnEnemy");
            CancelInvoke("SpawnEnemy2");

            InvokeRepeating("SpawnEnemy", 1f, 0.5f);
            InvokeRepeating("SpawnEnemy2", 1f, 0.3f);
            InvokeRepeating("SpawnSpaceShip", 1f, 1f);
        }
    }

    float GetHorizontalExtent()
    {
        float vertExtent = Camera.main.orthographicSize;
        return vertExtent * Screen.width / (float)Screen.height;
    }

    void SpawnEnemy()
    {
        float horzExtent = GetHorizontalExtent();

        float randomX = Random.Range(
            -horzExtent + 1f,
            horzExtent - 1f
        );

        float spawnY = Camera.main.orthographicSize + 1f;

        Vector2 spawnPosition = new Vector2(
            randomX,
            spawnY
        );

        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }

    void SpawnEnemy2()
    {
        float horzExtent = GetHorizontalExtent();

        float randomX = Random.Range(
            -horzExtent + 1f,
            horzExtent - 1f
        );

        float spawnY = Camera.main.orthographicSize + 1f;

        Vector2 spawnPosition = new Vector2(
            randomX,
            spawnY
        );

        Instantiate(enemy2Prefab, spawnPosition, Quaternion.identity);
    }

    void SpawnSpaceShip()
    {
        float horzExtent = GetHorizontalExtent();

        float randomX = Random.Range(
            -horzExtent + 1f,
            horzExtent - 1f
        );

        float spawnY = Camera.main.orthographicSize + 1f;

        Vector2 spawnPosition = new Vector2(
            randomX,
            spawnY
        );

        Instantiate(enemySpaceShipPrefab, spawnPosition, Quaternion.identity);
    }
}