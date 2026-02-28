using UnityEngine;
using UnityEngine.SceneManagement; // Thư viện quản lý các Màn chơi (Scene)

public class MyGameController : MonoBehaviour
{
    public GameObject gameOverPanel;

    void Start()
    {
        // Lúc mới vào game thì ẩn bảng Game Over đi
        gameOverPanel.SetActive(false);
    }

    public void ShowGameOver()
    {
        // Hàm này được gọi khi Player chết -> Hiện bảng lên
        gameOverPanel.SetActive(true);
    }

    public void RestartGame()
    {
        // Load lại cái Scene hiện tại đang chơi
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}