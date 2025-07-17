using OptionsPricer.Models;

namespace OptionsPricer.Logic
{
    public partial class BlackScholesPricer : IBlackScholesPricer
    {
        public OptionPrice PriceOption(Option option)
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
            var normal = MathNet.Numerics.Distributions.Normal.WithMeanStdDev(0, 1);
            var probOfInMoneyAtExperation = MathNet.Numerics.Distributions.Normal.WithMeanStdDev(0, 1).CumulativeDistribution(d1);
            
            var probOfOutMoneyAtExperation = K * Exp(-r * T) * normal.CumulativeDistribution(d2);

            var callPrice = S * probOfInMoneyAtExperation - probOfOutMoneyAtExperation;



            var discountStrikeToDay = K * Exp(-r * T);
            var putPrice = discountStrikeToDay * normal.CumulativeDistribution(-d2) - S * normal.CumulativeDistribution(-d1);


            var optionPrice = new OptionPrice
            {
                CallPrice = Convert.ToDecimal(callPrice),
                PutPrice = Convert.ToDecimal(putPrice)
            };

            return optionPrice;
        }

        //exponential function
        private double Exp(double powerOf)
        {
            var e = 2.7182818284590452353602874713527;
            return Math.Pow(e, powerOf);
        }

        
    }
}
