using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public static bool GameIsStart;
    public Camera StartCamera, GameCamera;

    public void GotoGame()
    {
        GameIsStart = true;
        Debug.Log("Игра началась!");

        GameCamera.enabled = true;
        StartCamera.enabled = false;
    }

    public void GoBackToPreview()
    {
        SceneManager.LoadScene("Game");
        GameIsStart = false;
        
    }
}
