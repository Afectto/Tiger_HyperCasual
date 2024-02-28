using UnityEngine;

public class AddTigerButton : Button
{
    [SerializeField] private Spawner _spawner;
    protected override void BuyItem()
    {
        _spawner.SpawnTiger();
    }
}
