using UnityEngine;
using UnityEngine.UI;

public class ValueManager : MonoBehaviour
{

    [SerializeField]private Text coinCountText;
    [SerializeField]private Text meatCountText;

    private void Start()
    {
        CurrencyManager.OnChangeCurrency += UpdateValue;
    }

    private void UpdateValue()
    {
        coinCountText = CurrencyManager.Instance.coinCountText;
        meatCountText = CurrencyManager.Instance.meatCountText;
    }

    private void OnDestroy()
    {
        // ReSharper disable once DelegateSubtraction
        CurrencyManager.OnChangeCurrency -= UpdateValue;
    }
}
