using UnityEngine;
using UnityEngine.UI;

public class ButtonView : MonoBehaviour
{
    [SerializeField] private Image _currencyImage;
    private Color _coinColor = new Color32(242, 191, 66, 255);
    private Color _creditColor = new Color32(128, 239, 243,255);
    
    public void UpdateButtonView(bool isCoins)
    {
        var button = transform.GetComponent<Button>();
        if (isCoins)
        {
            _currencyImage.sprite = Resources.Load<Sprite>("Coin");
            button.GetComponent<Image>().color = _coinColor;
        }
        else
        {
            _currencyImage.sprite = Resources.Load<Sprite>("Credit");
            button.GetComponent<Image>().color = _creditColor;
        }
        _currencyImage.color = Color.black;
    }
}
