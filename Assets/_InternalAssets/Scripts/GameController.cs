using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class GameController : MonoBehaviour
{
     public static GameController current;
     [HideInInspector]public UnityEvent OnConvertCoinToCredit = new UnityEvent();
     [HideInInspector]public UnityEvent OnBuy = new UnityEvent();
    
    private void Awake()
    {
        Singleton();
    }

    private void Update()
    {
        GameModel.Update();
    }

    private void Singleton()
    {
        if (current == null)
        {
            current = this;
        }
        if (current != this)
        {
            Destroy(this.gameObject);
        }
    }

    public void ConvertCoinToCredit(int coinToConvert)
    {
        GameModel.ConvertCoinToCredit(coinToConvert);
        GameModel.OperationComplete += result =>
        {
            OnConvertCoinToCredit.Invoke();
        };
    }

    public void BuyConsumableForGold(GameModel.ConsumableTypes consumableType)
    {
        GameModel.BuyConsumableForGold(consumableType);
        GameModel.OperationComplete += result =>
        {
            OnBuy.Invoke();
        };
    }

    public void BuyConsumableForCredits(GameModel.ConsumableTypes consumableType)
    {
        GameModel.BuyConsumableForSilver(consumableType);
        GameModel.OperationComplete += result =>
        {
            OnBuy.Invoke();
        };
    }
}
