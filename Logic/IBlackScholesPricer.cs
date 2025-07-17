using OptionsPricer.Models;
using static OptionsPricer.Models.BlackScholesPricer;

namespace OptionsPricer.Models
{
    public interface IBlackScholesPricer
    {
        public OptionPrice PriceOption(Option option);
    }
}