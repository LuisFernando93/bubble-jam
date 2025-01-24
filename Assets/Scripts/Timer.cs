using TMPro;
using UnityEditor.Tilemaps;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private bool timerOn;
    private float timeLeft;
    [SerializeField] private float timerValue;
    [SerializeField] private GameObject timerDisplay;
    [SerializeField] private GameObject scoreMenu;
        
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 1.0f;
        timerOn = true;
        timeLeft = timerValue;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerOn)
        {
            if (timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;
            } else
            {
                timeLeft = 0;
                timerOn = false;
                scoreMenu.GetComponent<ScoreMenu>().ShowFinalScore();
            }
            UpdateTimer();
        }
    }

    private void UpdateTimer()
    {
        int timeInt = Mathf.FloorToInt(timeLeft);
        timerDisplay.GetComponent<TextMeshProUGUI>().text = timeInt.ToString();
    }

    public void AddTime(int time)
    {
        timeLeft += time;
    }

    public void ReduceTime(int time)
    {
        timeLeft -= time;
    }
}
