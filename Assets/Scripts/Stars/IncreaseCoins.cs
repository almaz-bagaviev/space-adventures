using Assets.Scripts.Stars;
using UnityEngine;

public class IncreaseCoins : Increase
{
    public GameObject StarVFX;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        AddCoins(StarVFX, collision, 10, CoinText.coin, CoinTextPreview.coinP, CoinTextShop.coinS, "Coin", "CoinP", "CoinS", 19.49f);
    }

}
