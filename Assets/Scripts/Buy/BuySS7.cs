using UnityEngine;
using UnityEngine.UI;

public class BuySS7 : MonoBehaviour
{
    public int price;
    public static bool isboughtSS7; // куплен ли этот товар
    public string SpaseShipName7;
    public int boughtnewSS;
    public GameObject Panel;
    public Button StartButton; // кнопка СТАРТА ИГРЫ

    private void Start()
    {
        StartButton.enabled = false;
        boughtnewSS = PlayerPrefs.GetInt(SpaseShipName7, 0);

        if (boughtnewSS == 0)
        {
            Panel.SetActive(true);
        }

        else
            Panel.SetActive(false);
    }

    public void Buy()
    {
        if (CoinText.coin >= price && isboughtSS7 == false)
        {
            PlayerPrefs.GetInt(SpaseShipName7, 1);
            CoinText.coin -= price; //вычитается цена
            CoinTextPreview.coinP -= price;
            CoinTextShop.coinS -= price;
            Panel.SetActive(false);
            isboughtSS7 = true;
            StartButton.enabled = true;
        }

        else if (isboughtSS7 == true)
        {
            Panel.SetActive(false);
            StartButton.enabled = true;
        }
    }
}