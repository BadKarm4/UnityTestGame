using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseMenuScript : MonoBehaviour
{
    private void Awake()
    {
        gameObject.SetActive(false);
        GlobalEventManager.OnLose.AddListener(ShowLoseMenu);
    }

    private void ShowLoseMenu()
    {
        gameObject.SetActive(true);
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
