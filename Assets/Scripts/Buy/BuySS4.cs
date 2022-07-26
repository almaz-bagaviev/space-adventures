using UnityEngine;
using UnityEngine.UI;

public class BuySS4 : MonoBehaviour
{
    public int price;
    public static bool isboughtSS4; // куплен ли этот товар
    public string SpaseShipName4;
    public int boughtnewSS;
    public GameObject Panel;
    public Button StartButton; // кнопка СТАРТА ИГРЫ

    private void Start()
    {
        StartButton.enabled = false;
        boughtnewSS = PlayerPrefs.GetInt(SpaseShipName4, 0);

        if (boughtnewSS == 0)
        {
            Panel.SetActive(true);
        }

        else
            Panel.SetActive(false);
    }

    public void Buy()
    {
        if (CoinText.coin >= price && isboughtSS4 == false)
        {
            PlayerPrefs.GetInt(SpaseShipName4, 1);
            CoinText.coin -= price; //вычитается цена
            CoinTextPreview.coinP -= price;
            CoinTextShop.coinS -= price;
            Panel.SetActive(false);
            isboughtSS4 = true;
            StartButton.enabled = true;
        }

        else if (isboughtSS4 == true)
        {
            Panel.SetActive(false);
            StartButton.enabled = true;
        }
    }
}