using UnityEngine;
using UnityEngine.UI;

public class BuySS3 : MonoBehaviour
{
    public int price;
    public static bool isboughtSS3; // куплен ли этот товар
    public string SpaseShipName3;
    public int boughtnewSS;
    public GameObject Panel;
    public Button StartButton; // кнопка СТАРТА ИГРЫ

    private void Start()
    {
        StartButton.enabled = false;
        boughtnewSS = PlayerPrefs.GetInt(SpaseShipName3, 0);

        if (boughtnewSS == 0)
        {
            Panel.SetActive(true);
        }

        else
            Panel.SetActive(false);
    }

    public void Buy()
    {
        if (CoinText.coin >= price && isboughtSS3 == false)
        {
            PlayerPrefs.GetInt(SpaseShipName3, 1);
            CoinText.coin -= price; //вычитается цена
            CoinTextPreview.coinP -= price;
            CoinTextShop.coinS -= price;
            Panel.SetActive(false);
            isboughtSS3 = true;
            StartButton.enabled = true;
        }

        else if (isboughtSS3 == true)
        {
            Panel.SetActive(false);
            StartButton.enabled = true;
        }
    }
}