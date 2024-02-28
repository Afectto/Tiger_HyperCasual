using System;
using UnityEngine;
using UnityEngine.UI;

public class CurrencyManager : MonoBehaviour
{
    private float _coinCount;
    public Text coinCountText;
    public float CoinCount => _coinCount;

    private float _meatCount;
    public Text meatCountText;
    public float MeatCount => _meatCount;
    public static CurrencyManager Instance { get; private set; }


    public static Action OnChangeCurrency;
    
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            coinCountText.text = "0";
            meatCountText.text = "0";
            _coinCount = 0;
            _meatCount = 0;//TODO: поменять нули на загрузку если она будет
        }
        else
            Destroy(gameObject);
    }

    public void ChangeCoins(float amount)
    {
        _coinCount += amount;
        coinCountText.text = Mathf.FloorToInt(_coinCount).ToString();
        OnChangeCurrency?.Invoke();
    }
    
    public void ChangeMeat(float amount)
    {
        _meatCount += amount;
        meatCountText.text = Mathf.FloorToInt(_meatCount).ToString();
        OnChangeCurrency?.Invoke();
    }
}
