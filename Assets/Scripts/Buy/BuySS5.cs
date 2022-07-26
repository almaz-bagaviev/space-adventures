using UnityEngine;
using UnityEngine.UI;

public class BuySS5 : MonoBehaviour
{
    public int price;
    public static bool isboughtSS5; // куплен ли этот товар
    public string SpaseShipName5;
    public int boughtnewSS;
    public GameObject Panel;
    public Button StartButton; // кнопка СТАРТА ИГРЫ

    private void Start()
    {
        StartButton.enabled = false;
        boughtnewSS = PlayerPrefs.GetInt(SpaseShipName5, 0);

        if (boughtnewSS == 0)
        {
            Panel.SetActive(true);
        }

        else
            Panel.SetActive(false);
    }

    public void Buy()
    {
        if (CoinText.coin >= price && isboughtSS5 == false)
        {
            PlayerPrefs.GetInt(SpaseShipName5, 1);
            CoinText.coin -= price; //вычитается цена
            CoinTextPreview.coinP -= price;
            CoinTextShop.coinS -= price;
            Panel.SetActive(false);
            isboughtSS5 = true;
            StartButton.enabled = true;
        }

        else if (isboughtSS5 == true)
        {
            Panel.SetActive(false);
            StartButton.enabled = true;
        }
    }
}