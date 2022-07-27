using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Stars
{
    public class Increase : MonoBehaviour
    {

        public void AddCoins(GameObject GO, Collider2D collision, int coint2Add, int mainCoins, int previewCoins,
            int shopCoins, string mainKey, string previewKey, string shopKey, float vectorY)
        {
            if (collision.CompareTag("Player"))
            {
                mainCoins += coint2Add;
                previewCoins += coint2Add;
                shopCoins += coint2Add;
                PlayerPrefs.SetInt(mainKey, mainCoins);
                PlayerPrefs.SetInt(previewKey, previewCoins);
                PlayerPrefs.SetInt(shopKey, shopCoins);
                Destroy(gameObject);
                Instantiate(GO, new Vector3(-2.37f, vectorY, 0f), Quaternion.identity);

            }
        }
    }
}
