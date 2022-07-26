using UnityEngine;

public class RemoveObject : MonoBehaviour
{
    private void Update()
    {
        if (transform.position.y <= 4f)
                Destroy(gameObject);   
    } 
}
