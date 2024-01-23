using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(MainMenuView))]
public class MainMenuController : MonoBehaviour
{
    private MainMenuModel _model;
    private MainMenuView _view;

    [SerializeField] private Button _btnTrade;
    [SerializeField] private Button _btnStore;
    
    private void Start()
    {
        InitMvc();
        InitButtons();
        UpdateUI();
        
        GameController.current.OnBuy.AddListener(UpdateUI);
        GameController.current.OnConvertCoinToCredit.AddListener(UpdateCurrency);
    }

    private void InitMvc()
    {
        _model = new MainMenuModel();
        _view = GetComponent<MainMenuView>();
    }

    private void InitButtons()
    {
        _btnTrade.onClick.AddListener(_view.OpenTrade);
        _btnStore.onClick.AddListener(_view.OpenBuy);
    }
    
    private void UpdateUI()
    {
        UpdateCurrency();
        UpdateInventory();
    }
    
    private void UpdateCurrency()
    {
        _view.InitCurrency(_model.GetCoins(), _model.GetCredits());
    }

    private void UpdateInventory()
    {
        _view.UpdateInventory(_model.GetMedpacks(), _model.GetArmorPlates());
    }
}
