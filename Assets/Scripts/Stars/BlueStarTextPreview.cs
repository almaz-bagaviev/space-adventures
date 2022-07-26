using UnityEngine;
using UnityEngine.UI;

public class BlueStarTextPreview : MonoBehaviour
{
    public static int bluestarP;
    public static Text bluestartextP;

    private void Start()
    {
        bluestartextP = gameObject.GetComponent<Text>();
        bluestarP = PlayerPrefs.GetInt("StarP", bluestarP);
    }
    private void Update()
    {
        bluestartextP.text = bluestarP.ToString();
    }
}
