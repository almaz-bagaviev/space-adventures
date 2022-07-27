using Assets.Scripts.Stars;
using UnityEngine;
using UnityEngine.UI;

public class CoinTextShop : Star
{
    public static int coinS;
    public static Text coinTextS;

    private void Start()
    {
        Initial(coinS, coinTextS, "CoinS");
    }

    private void Update()
    {
        Shop(coinS, coinTextS);
    }
}
