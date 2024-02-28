using UnityEngine;

public class Butchery : Building
{
    public override void OnTriggerEnter(Collider other)
    {
        CurrencyManager.Instance.ChangeMeat(7);
    }
}
