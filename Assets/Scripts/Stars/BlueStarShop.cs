using Assets.Scripts.Stars;
using UnityEngine;
using UnityEngine.UI;

public class BlueStarShop : Star
{
    public static int bluestarS;
    public static Text bluestartextS;

    private void Start()
    {
        Initial(bluestarS, bluestartextS, "StarP");
    }
    private void Update()
    {
        Shop(bluestarS, bluestartextS);
    }
}
