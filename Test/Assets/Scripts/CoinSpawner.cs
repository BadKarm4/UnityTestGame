using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coin;
    public GameObject[] spawnpoints = { };

    private GameObject temp;

    int index;

    private void Awake()
    {
        CreateNewCoin();
        GlobalEventManager.OnCreateNewCoin.AddListener(CreateNewCoin);
    }

    private void CreateNewCoin()
    {
        index = Random.Range(0, spawnpoints.Length - 1);
        Instantiate(coin, spawnpoints[index].transform.position, Quaternion.identity);

        temp = spawnpoints[spawnpoints.Length - 1];
        spawnpoints[spawnpoints.Length - 1] = spawnpoints[index];
        spawnpoints[index] = temp;
    }
}
