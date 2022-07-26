using UnityEngine;
using UnityEngine.UI;

public class CoinTextPreview : MonoBehaviour
{
    public static int coinP;
    public static Text cointextP;

    private void Start()
    {
        cointextP = gameObject.GetComponent<Text>();
        coinP = PlayerPrefs.GetInt("CoinP", coinP);
    }
    private void Update()
    {
        cointextP.text = coinP.ToString();
    }
}
