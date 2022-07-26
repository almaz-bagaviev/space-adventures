using UnityEngine;
using UnityEngine.SceneManagement;

public class Shop : MonoBehaviour
{
    public Camera StartCamera, GameCamera, ShopCamera;

    public void ShopDonat()
    {
        ShopCamera.enabled = true;
        StartCamera.enabled = false;
        GameCamera.enabled = false;

    }
    public void GoBackPreview()
    {
        SceneManager.LoadScene("Game");
    }
}
