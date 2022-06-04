using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenuScript : MonoBehaviour
{
    private void Awake()
    {
        gameObject.SetActive(false);
        GlobalEventManager.OnWin.AddListener(ShowWinMenu);
    }

    private void ShowWinMenu()
    {
        gameObject.SetActive(true);
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
