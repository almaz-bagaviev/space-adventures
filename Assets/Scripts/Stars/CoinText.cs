using Assets.Scripts.Stars;
using UnityEngine;
using UnityEngine.UI;

public class CoinText : MonoBehaviour, IStar
{
    public static int coin;
    public static Text coinText;

    public void Initial(int obj, Text text, string key)
    {
        text = gameObject.GetComponent<Text>();
        obj = PlayerPrefs.GetInt(key, obj);
    }

    private void Start()
    {
        //Initial(coin, coinText, "Coin");
        coinText = gameObject.GetComponent<Text>();
        coin = PlayerPrefs.GetInt("Coin", coin);
    }

    private void Update()
    {
        coinText.text = coin.ToString();
    }
}
