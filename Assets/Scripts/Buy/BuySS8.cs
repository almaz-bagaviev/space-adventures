using UnityEngine;
using UnityEngine.UI;

public class BuySS8 : MonoBehaviour
{
    public int price;
    public static bool isboughtSS8; // куплен ли этот товар
    public string SpaseShipName8;
    public int boughtnewSS;
    public GameObject Panel;
    public Button StartButton; // кнопка СТАРТА ИГРЫ

    private void Start()
    {
        StartButton.enabled = false;
        boughtnewSS = PlayerPrefs.GetInt(SpaseShipName8, 0);

        if (boughtnewSS == 0)
        {
            Panel.SetActive(true);
        }

        else
            Panel.SetActive(false);
    }

    public void Buy()
    {
        if (CoinText.coin >= price && isboughtSS8 == false)
        {
            PlayerPrefs.GetInt(SpaseShipName8, 1);
            CoinText.coin -= price; //вычитается цена
            CoinTextPreview.coinP -= price;
            CoinTextShop.coinS -= price;
            Panel.SetActive(false);
            isboughtSS8 = true;
            StartButton.enabled = true;
        }

        else if (isboughtSS8 == true)
        {
            Panel.SetActive(false);
            StartButton.enabled = true;
        }
    }
}