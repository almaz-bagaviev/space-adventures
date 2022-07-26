using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Buy
{
    public abstract class BuySS : MonoBehaviour
    {
        public int price;
        public bool isBoughtSS;
        public string spaseShipName;
        public int boughtnewSS;
        public GameObject panel;
        public Button StartButton;

        public BuySS() { }

        public void App(string spaceShip, int bought, GameObject panel, Button button)
        {
            button.enabled = false;
            bought = PlayerPrefs.GetInt(spaceShip, 0);

            if (bought == 0) panel.SetActive(true);

            else panel.SetActive(false);
        }

        public void Buy(string spaceShip, int price, GameObject gameobject, bool isBoughtSS, Button button)
        {
            if (CoinText.coin >= price && isBoughtSS == false)
            {
                PlayerPrefs.GetInt(spaceShip, 1);
                CoinText.coin -= price;
                CoinTextPreview.coinP -= price;
                CoinTextShop.coinS -= price;
                gameobject.SetActive(false);
                isBoughtSS = true;
                button.enabled = true;
            }

            else if (isBoughtSS == true)
            {
                gameobject.SetActive(false);
                button.enabled = true;
            }
        }
    }
}