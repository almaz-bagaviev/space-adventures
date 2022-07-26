using UnityEngine;
using UnityEngine.UI;

public class BlueStarText : MonoBehaviour
{
    public static int bluestar;
    public static Text bluestartext;

    private void Start()
    {
        bluestartext = gameObject.GetComponent<Text>();
        bluestar = PlayerPrefs.GetInt("Star", bluestar);
    }
    private void Update()
    {
        bluestartext.text = bluestar.ToString();
    }
}
