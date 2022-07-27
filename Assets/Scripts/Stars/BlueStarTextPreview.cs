using Assets.Scripts.Stars;
using UnityEngine;
using UnityEngine.UI;

public class BlueStarTextPreview : Star
{
    public static int bluestarP;
    public static Text bluestartextP;

    private void Start()
    {
        Initial(bluestarP, bluestartextP, "StarP");
    }

    private void Update()
    {
        Shop(bluestarP, bluestartextP);
    }
}
