using UnityEngine;
using UnityEngine.UI;

public class BuySS1 : MonoBehaviour
{
    public int price;
    public static bool isboughtSS1; // куплен ли этот товар
    public string SpaseShipName1;
    public int boughtnewSS;
    public GameObject Panel;
    public Button StartButton; // кнопка СТАРТА ИГРЫ

    private void Start()
    {
        StartButton.enabled = false;
        boughtnewSS = PlayerPrefs.GetInt(SpaseShipName1, 0);

        if (boughtnewSS == 0)
        {
            Panel.SetActive(true);
        }

        else
            Panel.SetActive(false);
    }

    public void Buy()
    {
        if (CoinText.coin >= price && isboughtSS1 == false)
        {
            PlayerPrefs.GetInt(SpaseShipName1, 1);
            CoinText.coin -= price; //вычитается цена
            CoinTextPreview.coinP -= price;
            CoinTextShop.coinS -= price;
            Panel.SetActive(false);
            isboughtSS1 = true;
            StartButton.enabled = true;
        }

        else if (isboughtSS1 == true)
        {
            Panel.SetActive(false);
            StartButton.enabled = true;
        }
    }
}
