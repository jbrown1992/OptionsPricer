using OptionsPricer.Models;

namespace OptionsPricer.Logic
{
    public interface IBlackScholesPricer
    {
        public decimal PriceOption(Option option);
    }
}