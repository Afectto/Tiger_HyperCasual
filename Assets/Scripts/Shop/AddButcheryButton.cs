using UnityEngine;

public class AddButcheryButton : Button
{
    [SerializeField]private ShopBuildingButton shopBuildingButton;
    

    protected override void BuyItem()
    {
        shopBuildingButton.AddItemIfCan("Butchery");
    }
}
