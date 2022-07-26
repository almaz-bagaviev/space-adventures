using Assets.Scripts.Buy;
using UnityEngine;
using UnityEngine.UI;

public class BuySS2 : BuySS
{
    public BuySS2() { }
    private void Start()
    {
        App(spaseShipName, boughtnewSS, panel, StartButton);
    }
}