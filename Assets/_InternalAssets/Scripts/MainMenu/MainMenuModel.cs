public class MainMenuModel
{
    public int GetCoins()
    {
        var coins = GameModel.CoinCount;
        return coins;
    }

    public int GetCredits()
    {
        var credits = GameModel.CreditCount;
        return credits;
    }

    public int GetMedpacks()
    {
        var medpacks = GameModel.GetConsumableCount(GameModel.ConsumableTypes.Medpack);
        return medpacks;
    }

    public int GetArmorPlates()
    {
        var armorPlate = GameModel.GetConsumableCount(GameModel.ConsumableTypes.ArmorPlate);
        return armorPlate;
    }
}
