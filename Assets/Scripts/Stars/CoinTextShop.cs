using Assets.Scripts.Stars;
using UnityEngine;
using UnityEngine.UI;

public class CoinTextShop : MonoBehaviour, IStar
{
    public static int coinS;
    public static Text coinTextS;

    public void Initial(int obj, Text text, string key)
    {
        text = gameObject.GetComponent<Text>();
        obj = PlayerPrefs.GetInt(key, obj);
    }

    private void Start()
    {
        //Initial(coinS, coinTextS, "CoinS");
        coinTextS = gameObject.GetComponent<Text>();
        coinS = PlayerPrefs.GetInt("CoinS", coinS);
    }

    private void Update()
    {
        coinTextS.text = coinS.ToString();
    }
}
