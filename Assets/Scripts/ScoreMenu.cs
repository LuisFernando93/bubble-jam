using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreMenu : MonoBehaviour
{
    [SerializeField] private GameObject _scoreMenuContainer;
    [SerializeField] private GameObject _gameContainer;
    [SerializeField] private GameObject _finalScore;
    [SerializeField] private GameObject _scoreTracker;

    public void ShowFinalScore()
    {
        Time.timeScale = 0.0f;
        _finalScore.GetComponent<TextMeshProUGUI>().text = _scoreTracker.GetComponent<ScoreTracker>().score.ToString();
        _gameContainer.SetActive(false);
        _scoreMenuContainer.SetActive(true);
    }

    public void RetryButton()
    {
        SceneManager.LoadScene("Game");
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
