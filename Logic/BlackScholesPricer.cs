using OptionsPricer.Models;

namespace OptionsPricer.Logic
{
    public class BlackScholesPricer : IBlackScholesPricer
    {
        public decimal PriceOption(Option option)
        {
            //TODO: this is to price a call option
            var S = option.Price;
            var K = option.StrikePrice;
            var sigma = option.Volatility;
            var T = option.TimeUntilExpirationInYears;
            var r = option.RiskFreeInterestRate;

            var d1 = 0;
            var d2 = 0;

            var PV_K = K * Exp(-r * T);



            return 0;
        }

        //exponential function
        private double Exp(double powerOf)
        {
            var e = 2.7182818284590452353602874713527;
            return Math.Pow(e, powerOf);
        }
    }
}
