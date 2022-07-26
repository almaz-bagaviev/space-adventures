using UnityEngine;

public class IncreaseCoins : MonoBehaviour
{
    public GameObject StarVFX;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            CoinText.coin +=10;
            CoinTextPreview.coinP += 10;
            CoinTextShop.coinS += 10;
            PlayerPrefs.SetInt("Coin", CoinText.coin);
            PlayerPrefs.SetInt("CoinP", CoinTextPreview.coinP);
            PlayerPrefs.SetInt("CoinS", CoinTextShop.coinS);
            Destroy(gameObject);
            Instantiate(StarVFX, new Vector3(-2.37f, 19.49f, 0f), Quaternion.identity);
        }
    }
}
