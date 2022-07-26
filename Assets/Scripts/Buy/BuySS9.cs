using UnityEngine;
using UnityEngine.UI;

public class BuySS9 : MonoBehaviour
{
    public int price;
    public static bool isboughtSS9; // куплен ли этот товар
    public string SpaseShipName9;
    public int boughtnewSS;
    public GameObject Panel;
    public Button StartButton; // кнопка СТАРТА ИГРЫ


    private void Start()
    {
        StartButton.enabled = false;
        boughtnewSS = PlayerPrefs.GetInt(SpaseShipName9, 0);

        if (boughtnewSS == 0)
        {
            Panel.SetActive(true);
        }

        else
            Panel.SetActive(false);
    }

    public void Buy()
    {
        if (BlueStarText.bluestar >= price && isboughtSS9 == false)
        {
            PlayerPrefs.GetInt(SpaseShipName9, 1);
            BlueStarText.bluestar -= price;
            BlueStarTextPreview.bluestarP -= price;
            BlueStarShop.bluestarS -= price;
            Panel.SetActive(false);
            isboughtSS9 = true;
            StartButton.enabled = true;
        }

        else if (isboughtSS9 == true)
        {
            Panel.SetActive(false);
            StartButton.enabled = true;
        }
    }
}
