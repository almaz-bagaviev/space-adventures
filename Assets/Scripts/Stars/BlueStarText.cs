using Assets.Scripts.Stars;
using UnityEngine;
using UnityEngine.UI;

public class BlueStarText : Star
{
    public static int bluestar;
    public static Text bluestartext;

    private void Start()
    {
        Initial(bluestar, bluestartext, "Star");
    }
    private void Update()
    {
        Shop(bluestar, bluestartext);
    }
}
