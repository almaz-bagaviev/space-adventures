using UnityEngine;

public class PlanetMove : MonoBehaviour
{
    public float speed;

    void Update()
    {
        transform.Translate(0, speed * Time.deltaTime, 0);
    }
}