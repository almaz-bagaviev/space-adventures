using UnityEngine;
using UnityEngine.UI;

public class BlueStarShop : MonoBehaviour
{
    public static int bluestarS;
    public static Text bluestartextS;

    private void Start()
    {
        bluestartextS = gameObject.GetComponent<Text>();
        bluestarS = PlayerPrefs.GetInt("StarP", bluestarS);
    }
    private void Update()
    {
        bluestartextS.text = bluestarS.ToString();
    }
}
