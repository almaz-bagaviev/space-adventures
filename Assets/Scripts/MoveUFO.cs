using UnityEngine;

public class MoveUFO : MonoBehaviour
{
    public float speed;
    
    void Update()
    {
        transform.Translate(0, speed * Time.deltaTime, 0);
    }
}
