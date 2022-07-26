using UnityEngine;
using UnityEngine.UI;

public class BuySS6 : MonoBehaviour
{
    public int price;
    public static bool isboughtSS6; // куплен ли этот товар
    public string SpaseShipName6;
    public int boughtnewSS;
    public GameObject Panel;
    public Button StartButton; // кнопка СТАРТА ИГРЫ

    private void Start()
    {
        StartButton.enabled = false;
        boughtnewSS = PlayerPrefs.GetInt(SpaseShipName6, 0);

        if (boughtnewSS == 0)
        {
            Panel.SetActive(true);
        }

        else
            Panel.SetActive(false);
    }

    public void Buy()
    {
        if (CoinText.coin >= price && isboughtSS6 == false)
        {
            PlayerPrefs.GetInt(SpaseShipName6, 1);
            CoinText.coin -= price; //вычитается цена
            CoinTextPreview.coinP -= price;
            CoinTextShop.coinS -= price;
            Panel.SetActive(false);
            isboughtSS6 = true;
            StartButton.enabled = true;
        }

        else if (isboughtSS6 == true)
        {
            Panel.SetActive(false);
            StartButton.enabled = true;
        }
    }
}