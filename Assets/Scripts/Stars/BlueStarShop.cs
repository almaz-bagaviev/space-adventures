using Assets.Scripts.Stars;
using UnityEngine;
using UnityEngine.UI;

public class BlueStarShop : MonoBehaviour, IStar
{
    public static int bluestarS;
    public static Text bluestartextS;

    public void Initial(int obj, Text text, string key)
    {
        text = gameObject.GetComponent<Text>();
        obj = PlayerPrefs.GetInt(key, obj);
    }

    private void Start()
    {
        //Initial(bluestarS, bluestartextS, "StarP");

        bluestartextS = gameObject.GetComponent<Text>();
        bluestarS = PlayerPrefs.GetInt("StarP", bluestarS);
    }
    private void Update()
    {
        bluestartextS.text = bluestarS.ToString();
    }
}
