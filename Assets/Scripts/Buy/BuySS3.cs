using Assets.Scripts.Buy;
using UnityEngine;
using UnityEngine.UI;

public class BuySS3 : BuySS
{
    public BuySS3() { }

    private void Start()
    {
        App(spaseShipName, boughtnewSS, panel, StartButton);
    }
}