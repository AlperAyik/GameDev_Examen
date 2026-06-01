using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private float temp = 0;
    public GameObject explosionPrefab;
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveX, moveY, 0);

        transform.Translate(movement * speed * Time.deltaTime);

        float clampedX = Mathf.Clamp(transform.position.x, -15f, 15f);
        float clampedY = Mathf.Clamp(transform.position.y, -5f, 5f);

        transform.position = new Vector3(clampedX, clampedY, transform.position.z);

        if(temp < 1)
        {
            temp = 1;
            FindObjectOfType<HealthManager>().HealthBar();
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            FindObjectOfType<MissileManager>().ShootMissile();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            FindObjectOfType<HealthManager>().TakeHealth();
            Instantiate(explosionPrefab, collision.transform.position, Quaternion.identity);
        }

        if (collision.gameObject.CompareTag("Enemy2"))
        {
            FindObjectOfType<HealthManager>().TakeHealth2();
            Instantiate(explosionPrefab, collision.transform.position, Quaternion.identity);
        }

        if (collision.gameObject.CompareTag("EnemySpaceShip"))
        {
            FindObjectOfType<HealthManager>().TakeHealth3();
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        }

        if(collision.gameObject.CompareTag("PowerUp"))
        {
            FindObjectOfType<HealthManager>().AddHealth();
        }
        Destroy(collision.gameObject);
    }
}