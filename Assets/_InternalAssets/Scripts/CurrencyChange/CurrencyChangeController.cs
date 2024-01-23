using TMPro;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(CurrencyChangeView))]
public class CurrencyChangeController : MonoBehaviour
{
    [SerializeField] private TMP_InputField _input;
    [SerializeField] private Button _btnConfirm;
    [SerializeField] private Button _btnCancel;
    
    private CurrencyChangeView _view;
    private CurrencyChangeModel _model;
    
    private void Start()
    {
        Init();
    }

    private void Init()
    {
        _model = new CurrencyChangeModel();
        _view = GetComponent<CurrencyChangeView>();

        _view.InitCurrency(_model.GetCoins(), _model.GetCredits(), _model.GetCoinToCreditRate());
        
        _input.onValueChanged.AddListener(OnInputChange);
        _btnConfirm.onClick.AddListener(Confirm);
        _btnCancel.onClick.AddListener(Cancel);
        
        GameController.current.OnConvertCoinToCredit.AddListener(UpdateUI);
    }
    
    private void OnInputChange(string value)
    {
        _view.UpdatePotentialCredits(_model.GetCurrency(value));
    }
    
    private void Confirm()
    {
        int currencyToConvert = _model.ParseInput(_input.text);
        GameController.current.ConvertCoinToCredit(currencyToConvert);
    }
    
    private void Cancel()
    {
        _view.DisableCanvas();
        _input.text = "0";
    }

    private void UpdateUI()
    {
        _view.UpdateCurrency(_model.GetCoins(), _model.GetCredits());
    }
}
