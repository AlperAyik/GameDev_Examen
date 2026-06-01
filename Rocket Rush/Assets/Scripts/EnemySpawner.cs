using System.Threading.Tasks;
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
        if(FindObjectOfType<ScoreManager>().score > 100 && !speedIncreased)
        {
            speedIncreased = true;
            CancelInvoke("SpawnEnemy");
            InvokeRepeating("SpawnEnemy", 1f, 0.5f);
        } 
        if(FindObjectOfType<ScoreManager>().score > 500 && !spawnEnemy2)
        {
            spawnEnemy2 = true;
            InvokeRepeating("SpawnEnemy2", 1f, 0.5f);
        }
        if(FindObjectOfType<ScoreManager>().score > 1000 && !SpawnSpaceShipBool)
        {
            SpawnSpaceShipBool = true;
            CancelInvoke("SpawnEnemy");
            CancelInvoke("SpawnEnemy2");

            InvokeRepeating("SpawnEnemy", 1f, 0.5f);
            InvokeRepeating("SpawnEnemy2", 1f, 0.3f);
            InvokeRepeating("SpawnSpaceShip", 1f, 1f);
        }
    }

    void SpawnEnemy()
    {
        float randomX = Random.Range(-15f, 15f);

        Vector2 spawnPosition = new Vector2(randomX, 8f);

        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }

    void SpawnEnemy2()
    {
        float randomX = Random.Range(-15f, 15f);

        Vector2 spawnPosition = new Vector2(randomX, 8f);

        Instantiate(enemy2Prefab, spawnPosition, Quaternion.identity);
    }

    void SpawnSpaceShip()
    {
        float randomX = Random.Range(-15f, 15f);

        Vector2 spawnPosition = new Vector2(randomX, 8f);

        Instantiate(enemySpaceShipPrefab, spawnPosition, Quaternion.identity);
    }
}