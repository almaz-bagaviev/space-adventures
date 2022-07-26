using UnityEngine;
using UnityEngine.UI;

public class CoinTextShop : MonoBehaviour
{
    public static int coinS;
    public static Text cointextS;

    private void Start()
    {
        cointextS = gameObject.GetComponent<Text>();
        coinS = PlayerPrefs.GetInt("CoinS", coinS);
    }
    private void Update()
    {
        cointextS.text = coinS.ToString();
    }
}
