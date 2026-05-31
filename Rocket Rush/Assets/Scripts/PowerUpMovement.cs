using UnityEngine;

public class PowerUpMovement : MonoBehaviour
{
    public float speed = 3f;

    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }
}