using UnityEngine;

public class AddBankButton : Button
{
    [SerializeField]private ShopBuildingButton shopBuildingButton;

    protected override void BuyItem()
    {
        shopBuildingButton.AddItemIfCan("Bank");
    }
}
