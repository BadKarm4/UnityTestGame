using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickUpper : MonoBehaviour
{
    public GameObject particle;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Instantiate(particle, gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);
            GlobalEventManager.SendCoinPickUpped();
            GlobalEventManager.SendCreateNewCoin();
        }
    }
}
