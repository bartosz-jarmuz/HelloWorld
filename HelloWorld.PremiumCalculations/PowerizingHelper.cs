using System;

namespace HelloWorld.PremiumCalculations
{
    static class PowerizingHelper
    {
        public static decimal PerformPowerCalcualtion(decimal a, decimal b)
        {
            var initialResult = Math.Pow(decimal.ToDouble(a), decimal.ToDouble(b));

            return Convert.ToDecimal(initialResult);
        }
    }
}