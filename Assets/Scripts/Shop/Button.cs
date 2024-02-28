using UnityEngine;
using UnityEngine.UI;

public abstract class Button : MonoBehaviour
{
    [SerializeField] protected int price;
    [SerializeField] private int maxBuyCount;
    [SerializeField] private Text value;

    private int _basePrice;
    private int _alreadyBuyCount = 1;

    private void Start()
    {
        value.text = price.ToString();
        _basePrice = price;
    }

    protected abstract void BuyItem();

    public void BuyIfYouCan(bool isCoin)
    {
        var currentValue = isCoin ? CurrencyManager.Instance.CoinCount : CurrencyManager.Instance.MeatCount;

        if (currentValue >= price && _alreadyBuyCount < maxBuyCount )
        {
            ChangeCurrency(isCoin);
            _alreadyBuyCount++;
            price = _basePrice * _alreadyBuyCount;
            BuyItem();
        }

        UpdateValueText();
    }

    private void ChangeCurrency(bool isCoin)
    {
        if (isCoin)
        {
            CurrencyManager.Instance.ChangeCoins(-price);
        }
        else
        {
            CurrencyManager.Instance.ChangeMeat(-price);
        } 
    }

    private void UpdateValueText()
    {
        if (_alreadyBuyCount < maxBuyCount)
        {
            value.text = price.ToString();
        }
        else
        {
            value.text = "MAX";
        }
    }
}
