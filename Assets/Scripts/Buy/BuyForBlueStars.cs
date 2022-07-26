using UnityEngine;
using UnityEngine.UI;

public class BuyForBlueStars : MonoBehaviour
{
    public int price;
    public bool isbought; // куплен ли этот товар
    public string SpaseShipName;
    public int boughtnewSS;
    public GameObject Panel, checkmark;
    public Button StartButton; // кнопка СТАРТА ИГРЫ


    private void Start()
    {
        StartButton.enabled = false;
        boughtnewSS = PlayerPrefs.GetInt(SpaseShipName, 0);

        if (boughtnewSS == 0)
        {
            Panel.SetActive(true);
        }

        else
            Panel.SetActive(false);
    }

    public void Buy()
    {
        if (BlueStarText.bluestar >= price && isbought == false)
        {
            PlayerPrefs.GetInt(SpaseShipName, 1);
            BlueStarText.bluestar -= price;
            BlueStarTextPreview.bluestarP -= price;
            BlueStarShop.bluestarS -= price;
            Panel.SetActive(false);
            isbought = true;
            StartButton.enabled = true;
            checkmark.SetActive(true);
        }

        else if (isbought == true)
        {
            Panel.SetActive(false);
            checkmark.SetActive(true);
        }
    }
}
