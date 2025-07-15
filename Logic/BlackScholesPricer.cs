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

            var d1 = (Math.Log(S/K) + (r+(Math.Pow(sigma, 2))/2)*T) / (sigma*Math.Sqrt(T));
            var d2 = d1 - sigma * Math.Sqrt(T);

            //https://www.youtube.com/watch?v=J6OySvT-PDE
            var call = (S* StatisticFormula.NormalDistribution());
            var put = 0;


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
