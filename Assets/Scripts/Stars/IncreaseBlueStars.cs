using UnityEngine;

public class IncreaseBlueStars : MonoBehaviour
{
    public GameObject BlueStarVFX;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            BlueStarText.bluestar +=5;
            BlueStarTextPreview.bluestarP += 5;
            BlueStarShop.bluestarS += 5;
            PlayerPrefs.SetInt("Star", BlueStarText.bluestar);
            PlayerPrefs.SetInt("StarP", BlueStarTextPreview.bluestarP);
            PlayerPrefs.SetInt("StarP", BlueStarShop.bluestarS);
            Destroy(gameObject);
            Instantiate(BlueStarVFX, new Vector3(-2.37f, 19f, 0f), Quaternion.identity);
        }
    }
}
