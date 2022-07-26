using UnityEngine;
using UnityEngine.UI;

public class BuySS2 : MonoBehaviour
{
    public int price;
    public static bool isboughtSS2; // куплен ли этот товар
    public string SpaseShipName2;
    public int boughtnewSS;
    public GameObject Panel;
    public Button StartButton; // кнопка СТАРТА ИГРЫ

    private void Start()
    {
        StartButton.enabled = false;
        boughtnewSS = PlayerPrefs.GetInt(SpaseShipName2, 0);

        if (boughtnewSS == 0)
        {
            Panel.SetActive(true);
        }

        else
            Panel.SetActive(false);
    }

    public void Buy()
    {
        if (CoinText.coin >= price && isboughtSS2 == false)
        {
            PlayerPrefs.GetInt(SpaseShipName2, 1);
            CoinText.coin -= price; //вычитается цена
            CoinTextPreview.coinP -= price;
            CoinTextShop.coinS -= price;
            Panel.SetActive(false);
            isboughtSS2 = true;
            StartButton.enabled = true;
        }

        else if (isboughtSS2 == true)
        {
            Panel.SetActive(false);
            StartButton.enabled = true;
        }
    }
}