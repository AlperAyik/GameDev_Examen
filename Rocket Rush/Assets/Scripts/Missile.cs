using UnityEngine;

public class Missile : MonoBehaviour
{
    public float speed = 10f;
    public GameObject explosionPrefab;

    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy") ||
            other.CompareTag("Enemy2") ||
            other.CompareTag("EnemySpaceShip"))
        {
            FindAnyObjectByType<ScoreManager>().score += 30;
            FindAnyObjectByType<ScoreManager>().scoreText.text = "Score: " + Mathf.FloorToInt(FindAnyObjectByType<ScoreManager>().score);
            
            Instantiate(
                explosionPrefab,
                transform.position,
                Quaternion.identity
            );

            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}