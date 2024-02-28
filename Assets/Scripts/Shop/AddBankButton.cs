using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class AddBankButton : Button
{
    [SerializeField]private ShopBuildingButton shopBuildingButton;

    protected override void BuyItem()
    {
        shopBuildingButton.AddItemIfCan("Bank");
    }
}
