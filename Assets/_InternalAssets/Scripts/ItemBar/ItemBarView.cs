using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemBarView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _consumableCount;
    [SerializeField] private TextMeshProUGUI _name;
    [SerializeField] private TextMeshProUGUI _description;
    [SerializeField] private TextMeshProUGUI _price;
    [SerializeField] private Image _itemImage;

    public void InitView(ItemPreset preset, int Price, int Number)
    {
        _name.text = preset.Name;
        _description.text = preset.Description;
        _itemImage.sprite = preset.Image;

        UpdatePrice(Price);
        UpdateConsumableCount(Number);
    }

    private void UpdatePrice(int Price)
    {
        _price.text = Price.ToString();
    }

    public void UpdateConsumableCount(int Number)
    {
        _consumableCount.text = Number.ToString();
    }
}