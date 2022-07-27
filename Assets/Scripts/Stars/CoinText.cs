using Assets.Scripts.Stars;
using UnityEngine;
using UnityEngine.UI;

public class CoinText : Star
{
    public static int coin;
    public static Text coinText;
    
    private void Start()
    {
        Initial(coin, coinText, "Coin");
    }
    private void Update()
    {
        Shop(coin, coinText);
    }
}
