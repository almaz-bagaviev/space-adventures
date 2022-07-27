using Assets.Scripts.Stars;
using UnityEngine;
using UnityEngine.UI;

public class CoinTextPreview : MonoBehaviour, IStar
{
    public static int coinP;
    public static Text coinTextP;

    public void Initial(int obj, Text text, string key)
    {
        text = gameObject.GetComponent<Text>();
        obj = PlayerPrefs.GetInt(key, obj);
    }

    private void Start()
    {
        //Initial(coinP, coinTextP, "CoinP");
        coinTextP = gameObject.GetComponent<Text>();
        coinP = PlayerPrefs.GetInt("CoinP", coinP);
    }

    private void Update()
    {
        coinTextP.text = coinP.ToString();
    }
}
