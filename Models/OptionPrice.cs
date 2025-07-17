namespace OptionsPricer.Models;

    public class OptionPrice
    {
        public decimal CallPrice { get; set; }
        public decimal PutPrice { get; set; }

    public decimal CallPriceRounded()
    {
        return Math.Round(CallPrice, 2);
    }

    public decimal PutPriceRounded()
    {
        return Math.Round(PutPrice, 2);
    }
}
