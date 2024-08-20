using UnityEngine;
using TMPro;

public class MoneyCalculate : MonoBehaviour
{
    public int coin = 0;
    public int val = 1;
    public TMP_Text placeholder;

    public void GenerateRandomNumber()
    {
    }

    public void IncreaseCoin(int value)
    {
        coin+=value;
        Debug.Log($"");
        UpdateCoin();
    }

    public void ReduceCoin(int value)
    {
        // Check value below zero
        if(coin >= value)
        {
            coin-=value;
            UpdateCoin();
        }
        else
        {
            Debug.Log($"Don't have enough money!");
        }
    }

    public void UpdateCoin()
    {
        placeholder.text = "Coin:" + coin;
    }

    void Start()
    {
        UpdateCoin();
    }
}
