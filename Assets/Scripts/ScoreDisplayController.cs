using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreDisplayController : MonoBehaviour
{
    public TextMeshProUGUI texComponent;
    public CoinCollector coinCollector;
    public GameObject winMessage;

    private int totalCoinsCount;
    // Start is called before the first frame update
    void Start()
    {
        winMessage.SetActive(false);
        var allCoins = FindObjectsOfType<CoinTag>();
        totalCoinsCount = allCoins.Length;
    }

    // Update is called once per frame
    void Update()
    {
        bool isGameFinished = coinCollector.collectedCoinsCount >= totalCoinsCount;
        if (isGameFinished)
        {
            winMessage.SetActive(true);
        }
        texComponent.text =
            $"Coin collected: {coinCollector.collectedCoinsCount}/{totalCoinsCount}"; //coinCollector.collectedCoinsCount.ToString() + "/" + totalCoinsCount;
        
    }
}
