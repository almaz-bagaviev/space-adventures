using UnityEngine;

public class AccelerometerSS1 : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private float LeftLimit = -2.4f, RightLimit = 2.4f; // Ограничение для движения игрока по экрану, чтобы он не выходил за пределы камеры

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Vector3 Acceleration = Input.acceleration;
        rb.velocity = new Vector3(Acceleration.x * speed, 0f, 0f);

        gameObject.transform.position = new Vector2(Mathf.Clamp(transform.position.x, LeftLimit, RightLimit), transform.position.y);
    }
}

