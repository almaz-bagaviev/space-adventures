using System.Collections;
using UnityEngine;

namespace Assets.Scripts.AccelerometerS
{
    public class Accelerometer : MonoBehaviour
    {
        public float speed;
        Rigidbody2D rb;
        float LeftLimit = -2.4f, RightLimit = 2.4f;

        private void Start()
        {
            rb = gameObject.GetComponent<Rigidbody2D>();
        }

        private  void Update()
        {
            Vector3 Acceleration = Input.acceleration;
            rb.velocity = new Vector3(Acceleration.x * speed, 0f, 0f);

            gameObject.transform.position = new Vector2(Mathf.Clamp(transform.position.x, LeftLimit, RightLimit), transform.position.y);
        }
    }
}