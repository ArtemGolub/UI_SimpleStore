using UnityEngine;

public class ItemBarModel
{
    public bool IsCoinPrice;
    
    public int GetConsumableCount(GameModel.ConsumableTypes type)
    {
        var count = GameModel.GetConsumableCount(type);
        return count;
    }

    public int GetPrice(GameModel.ConsumableTypes type)
    {
        if (GameModel.ConsumablesPrice.TryGetValue(type, out var consumableConfig))
        {
            if (consumableConfig.CreditPrice != 0)
            {
                return consumableConfig.CreditPrice;
            }
            else
            {
                IsCoinPrice = true;
                return consumableConfig.CoinPrice;
            }
        }
        return 0;
    }
    
    public void BuyItem(GameModel.ConsumableTypes type)
    {
        if(GameModel.HasRunningOperations) return;
        switch (type)
        {
            case GameModel.ConsumableTypes.Medpack:
            {
                GameController.current.BuyConsumableForGold(type);
                break;
            }
            case GameModel.ConsumableTypes.ArmorPlate:
            {
                GameController.current.BuyConsumableForCredits(type);
                break;
            }
            case GameModel.ConsumableTypes.None:
            {
                Debug.LogError("No Buy data for item type: " + type);
                break;
            }
            default:
            {
                Debug.LogError("No Buy data for item type: " + type);
                break;
            }
        }
    }
}