using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class AddButcheryButton : Button
{
    [SerializeField]private ShopBuildingButton shopBuildingButton;
    

    protected override void BuyItem()
    {
        shopBuildingButton.AddItemIfCan("Butchery");
    }
}
