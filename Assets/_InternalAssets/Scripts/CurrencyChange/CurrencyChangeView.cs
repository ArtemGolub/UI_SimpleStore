using TMPro;
using UnityEngine;

public class CurrencyChangeView : MonoBehaviour
{
    [SerializeField] private Canvas _canvas;
    [SerializeField] private TextMeshProUGUI _creditsForCoin;
    [SerializeField] private TextMeshProUGUI _currentCoins;
    [SerializeField] private TextMeshProUGUI _currentCredits;
    [SerializeField] private TextMeshProUGUI _totalGetCoins;


    public void InitCurrency(int CurrentCoins, int CurrentCredits, int CoinToCreditRate)
    {
        _creditsForCoin.text = CoinToCreditRate.ToString();
        _totalGetCoins.text = "0";
        UpdateCurrency(CurrentCoins, CurrentCredits);
    }

    public void UpdateCurrency(int CurrentCoins, int CurrentCredits)
    {
        _currentCoins.text = CurrentCoins.ToString();
        _currentCredits.text = CurrentCredits.ToString();
    }

    public void UpdatePotentialCredits(int value)
    {
        _totalGetCoins.text = value.ToString();
    }

    public void DisableCanvas()
    {
        _canvas.enabled = false;
    }
}