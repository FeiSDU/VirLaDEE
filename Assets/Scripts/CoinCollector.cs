using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    public int collectedCoinsCount = 0;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(message:"Collied with " + other.gameObject.name);
        CoinTag coinTag = other.gameObject.GetComponent<CoinTag>();
        bool isCoin = (coinTag != null);

        if (isCoin)
        {
            other.gameObject.SetActive(false);
            collectedCoinsCount++;
        }

    }

   //private void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log(message:"Collied with " + collision.gameObject.name);
    //}
}
