public class AddSpeedToTigerButton : Button
{
    protected override void BuyItem()
    {
        TigerSpeedManager.IncreasedSpeed(1.025f);//Увеличиваю скорость на 2,5%
    }
}
