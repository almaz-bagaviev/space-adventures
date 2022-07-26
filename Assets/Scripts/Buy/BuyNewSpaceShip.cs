using UnityEngine;
using UnityEngine.UI;
public class BuyNewSpaceShip : MonoBehaviour
{
    public int price;
    public bool isbought;
    public string SpaseShipName;
    public int boughtnewSS;
    public GameObject Panel, checkmark;
    public Button StartButton;

    private void Start()
    {
        StartButton.enabled = false;
        boughtnewSS = PlayerPrefs.GetInt(SpaseShipName, 0);

        if(boughtnewSS == 0)
        {
              Panel.SetActive(true);
        }

        else
            Panel.SetActive(false);
    }

    public void Buy()
    {
        if (CoinText.coin >= price && isbought == false)
        {
            PlayerPrefs.GetInt(SpaseShipName, 1);
            CoinText.coin -= price; //вычитается цена
            CoinTextPreview.coinP -= price;
            CoinTextShop.coinS -= price;
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
