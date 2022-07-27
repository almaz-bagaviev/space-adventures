using Assets.Scripts.Stars;
using UnityEngine;
using UnityEngine.UI;

public class BlueStarTextPreview : MonoBehaviour, IStar
{
    public static int bluestarP;
    public static Text bluestartextP;

    public void Initial(int obj, Text text, string key)
    {
        text = gameObject.GetComponent<Text>();
        obj = PlayerPrefs.GetInt(key, obj);
    }

    private void Start()
    {
        //Initial(bluestarP, bluestartextP, "StarP");
        bluestartextP = gameObject.GetComponent<Text>();
        bluestarP = PlayerPrefs.GetInt("StarP", bluestarP);
    }

    private void Update()
    {
        bluestartextP.text = bluestarP.ToString();
    }
}
