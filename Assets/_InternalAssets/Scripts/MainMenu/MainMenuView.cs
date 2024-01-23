using TMPro;
using UnityEngine;


public class MainMenuView : MonoBehaviour
{
    [Header("Canvases")]
    [SerializeField] private Canvas _tradeCanvas;
    [SerializeField] private Canvas _ShopCanvas;
    [Header("Text")]
    [SerializeField] private TextMeshProUGUI _currentCoinTxt;
    [SerializeField] private TextMeshProUGUI _currentCreditTxt;
    [SerializeField] private TextMeshProUGUI _medkitCount;
    [SerializeField] private TextMeshProUGUI _armorPlatesCount;

    public void OpenTrade()
    {
        _tradeCanvas.enabled = true;
        _ShopCanvas.enabled = false;
    }

    public void OpenBuy()
    {
        _tradeCanvas.enabled = false;
        _ShopCanvas.enabled = true;
    }

    public void InitCurrency(int coins, int credits)
    {
        _currentCoinTxt.text = coins.ToString();
        _currentCreditTxt.text = credits.ToString();
    }

    public void UpdateInventory(int medKits, int armorPlates)
    {
        _medkitCount.text = medKits.ToString();
        _armorPlatesCount.text = armorPlates.ToString();
    }
}