using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class AddTigerButton : Button
{
    [SerializeField] private Spawner _spawner;
    protected override void BuyItem()
    {
        _spawner.SpawnTiger();
    }
}
