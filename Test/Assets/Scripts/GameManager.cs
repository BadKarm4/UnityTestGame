using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text pointsText;
    public Text timeText;
    public float time;
    public int forWin = 0;

    private int count = 0;
    private float seconds = 0;
    private float timeLeft = 0f;

    private void Awake()
    {
        timeLeft = time;
        StartCoroutine(StartTimer());
        GlobalEventManager.OnCoinPickUpped.AddListener(CoinPickUpped);
    }

    private IEnumerator StartTimer()
    {
        while (timeLeft > 1)
        {
            timeLeft -= Time.deltaTime;
            ChangeTimeText();
            yield return null;
        }
    }

    private void ChangeTimeText()
    {
        if (timeLeft <= 1)
        {
            timeLeft = 0;
            Time.timeScale = 0;
            GlobalEventManager.SendLoseMenu();
        }

        if (timeLeft >= time)
        {
            timeLeft = time;
        }

        seconds = Mathf.FloorToInt(timeLeft % 60);
        timeText.text = seconds.ToString();
    }

    private void CoinPickUpped()
    {
        timeLeft += 5;
        count++;
        if (count == forWin)
        {
            Time.timeScale = 0;
            GlobalEventManager.SendWinMenu();
        }
        pointsText.text = count.ToString();
    }
}
