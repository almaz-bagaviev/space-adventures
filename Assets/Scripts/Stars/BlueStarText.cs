using Assets.Scripts.Stars;
using UnityEngine;
using UnityEngine.UI;

public class BlueStarText : MonoBehaviour, IStar
{
    public static int bluestar;
    public static Text bluestartext;

    public void Initial(int obj, Text text, string key)
    {
        text = gameObject.GetComponent<Text>();
        obj = PlayerPrefs.GetInt(key, obj);
    }

    private void Start()
    {
        //Initial(bluestar, bluestartext, "Star");
        bluestartext = gameObject.GetComponent<Text>();
        bluestar = PlayerPrefs.GetInt("Star", bluestar);
    }
    private void Update()
    {
        bluestartext.text = bluestar.ToString();
    }
}
