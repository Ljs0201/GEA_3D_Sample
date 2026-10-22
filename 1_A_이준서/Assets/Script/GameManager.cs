using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject gameOverPanel;
    public GameObject clearPanel; // 추가된 부분
    public string titleSceneName = "Title";

    void Awake()
    {
        Instance = this;
        Time.timeScale = 1f;      // 다시 불러와도 시간 정상
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    // 추가된 게임 클리어 함수
    public void GameClear()
    {
        clearPanel.SetActive(true);
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void Retry()
    {
        string scene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(scene);
    }

    public void GoTitle()
    {
        SceneManager.LoadScene(titleSceneName);
    }
}