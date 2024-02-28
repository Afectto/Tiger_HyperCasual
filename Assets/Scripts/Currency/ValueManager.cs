using UnityEngine;
using UnityEngine.UI;

public class ValueManager : MonoBehaviour
{

    [SerializeField]private Text coinCountText;
    [SerializeField]private Text meatCountText;

    private void Update()
    {
        coinCountText = CurrencyManager.Instance.coinCountText;
        meatCountText = CurrencyManager.Instance.meatCountText;
    }
}
