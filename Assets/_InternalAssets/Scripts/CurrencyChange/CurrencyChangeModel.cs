public class CurrencyChangeModel
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

    public int GetCoinToCreditRate()
    {
        var rate = GameModel.CoinToCreditRate;
        return rate;
    }
    
    public int GetCurrency(string inputCoins)
    {
        var total = ParseInput(inputCoins) * GameModel.CoinToCreditRate;
        return total;
    }
    public int ParseInput(string inputCoins)
    {
        if (!int.TryParse(inputCoins, out int coins)) return 0;
        return coins;
    }
}
