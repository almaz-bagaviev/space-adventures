using Assets.Scripts.Stars;
using UnityEngine;

public class IncreaseBlueStars : Increase
{
    public GameObject BlueStarVFX;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        AddCoins(BlueStarVFX, collision, 5, BlueStarText.bluestar, BlueStarTextPreview.bluestarP, BlueStarShop.bluestarS,
            "Star", "StarP", "StarS", 19f);
    }
}
