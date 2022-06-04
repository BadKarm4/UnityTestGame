using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GlobalEventManager : MonoBehaviour
{
    public static UnityEvent OnCoinPickUpped = new UnityEvent();
    public static UnityEvent OnCreateNewCoin = new UnityEvent();
    public static UnityEvent OnWin = new UnityEvent();
    public static UnityEvent OnLose = new UnityEvent();

    public static void SendCoinPickUpped()
    {
        OnCoinPickUpped.Invoke();
    }

    public static void SendCreateNewCoin()
    {
        OnCreateNewCoin.Invoke();
    }

    public static void SendWinMenu()
    {
        OnWin.Invoke();
    }

    public static void SendLoseMenu()
    {
        OnLose.Invoke();
    }
}
