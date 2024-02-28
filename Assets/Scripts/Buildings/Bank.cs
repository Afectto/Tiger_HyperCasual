using UnityEngine;

public class Bank : Building
{
    public override void OnTriggerEnter(Collider other)
    {
        CurrencyManager.Instance.ChangeCoins(5);
    }
}
