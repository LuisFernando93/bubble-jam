using TMPro;
using UnityEngine;

public class ScoreTracker : MonoBehaviour
{
    public int score { get; private set; }
    [SerializeField] private GameObject _scoreDisplay;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        _scoreDisplay.GetComponent<TextMeshProUGUI>().text = score.ToString();
    }

    public void AddScore(int value)
    {
        score += value;
    }
}
