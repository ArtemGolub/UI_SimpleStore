using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(ItemBarView))]
public class ItemBar : MonoBehaviour
{
     [SerializeField] private ItemPreset _preset;
     [SerializeField] private Button _btnBuy;

     private ItemBarView _view;
     private ItemBarModel _model;

     private void Start()
     {
          InitItemBar();
     }
     private void InitItemBar()
     {
          InitMvc();
          _btnBuy.onClick.AddListener(BuyItem);
          GameController.current.OnBuy.AddListener(UpdateConsumables);
     }

     private void InitMvc()
     {
          _model = new ItemBarModel();
          _view = GetComponent<ItemBarView>();
          _view.InitView(_preset, _model.GetPrice(_preset.type), _model.GetConsumableCount(_preset.type));
          _btnBuy.GetComponent<ButtonView>().UpdateButtonView(_model.IsCoinPrice);
     }

     private void BuyItem()
     { 
          _model.BuyItem(_preset.type);
     }

     private void UpdateConsumables()
     {
          _view.UpdateConsumableCount(_model.GetConsumableCount(_preset.type));
     }
}
