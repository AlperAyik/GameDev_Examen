using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private float temp = 0;

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveX, moveY, 0);

        transform.Translate(movement * speed * Time.deltaTime);

        if(temp < 1)
        {
            temp = 1;
            FindObjectOfType<HealthManager>().Health();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            FindObjectOfType<HealthManager>().Health();
        }

        if(collision.gameObject.CompareTag("PowerUp"))
        {
            FindObjectOfType<HealthManager>().health += 20;
            FindObjectOfType<HealthManager>().healthText.text = "Health: " + Mathf.FloorToInt(FindObjectOfType<HealthManager>().health);
            Destroy(collision.gameObject);
        }
    }
}