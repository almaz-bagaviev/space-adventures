using UnityEngine;

public class Lose : MonoBehaviour
{
    public GameObject LosePanel;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("UFO") || collision.gameObject.CompareTag("AsteroidGame"))
        {
            LosePanel.SetActive(true);
            Debug.Log("Взрыв создан");

        }
    }
}
