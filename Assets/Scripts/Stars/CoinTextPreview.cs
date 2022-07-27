using Assets.Scripts.Stars;
using UnityEngine;
using UnityEngine.UI;

public class CoinTextPreview : Star
{
    public static int coinP;
    public static Text coinTextP;

    private void Start()
    {
        Initial(coinP, coinTextP, "CoinP");
    }

    private void Update()
    {
        Shop(coinP, coinTextP);
    }
}
