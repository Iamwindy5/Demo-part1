using UnityEngine;
using UnityEngine.SceneManagement;

public class MyMainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Battle"); // Mở màn chơi Battle
    }
}