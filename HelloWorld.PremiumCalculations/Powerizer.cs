using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.Contracts;

namespace HelloWorld.PremiumCalculations
{
    public class Powerizer : ICalculator
    {
        private ILogger logger;

        public Powerizer(ILogger logger)
        {
            this.logger = logger;
        }

        public decimal Calculate(decimal a, decimal b)
        {
             logger.Log($"Calculating power of {a} and {b}");
             return PowerizingHelper.PerformPowerCalcualtion(a, b);
        }
    }
}
