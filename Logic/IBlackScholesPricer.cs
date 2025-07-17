using OptionsPricer.Models;
using static OptionsPricer.Logic.BlackScholesPricer;

namespace OptionsPricer.Logic
{
    public interface IBlackScholesPricer
    {
        public OptionPrice PriceOption(Option option);
    }
}