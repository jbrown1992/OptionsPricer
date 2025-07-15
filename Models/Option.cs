namespace OptionsPricer.Models;

public class Option
{
    public double Volatility { get; set; }
    public double Price { get; set; }
    public double StrikePrice { get; set; }
    public double TimeUntilExpirationInYears { get; set; }
    public double RiskFreeInterestRate { get; set; }
    public OptionType Type { get; set; }
}
