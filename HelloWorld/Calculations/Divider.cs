using System;
using HelloWorld.Contracts;

namespace HelloWorld.ConsoleApp.Calculations
{
    class Divider : ICalculator
    {
        private ILogger logger;

        public Divider(ILogger logger)
        {
            this.logger = logger;
        }

        public decimal Calculate(decimal a, decimal b)
        {
            this.logger.Log($"Attempting to divide {a} by {b}");

            try
            {
                var result = a / b;
                this.logger.Log($"The result of {a} by {b} is {result}");
                return result;
            }
            catch (Exception ex)
            {
                this.logger.Log(ex.ToString());
                throw;
            }
        }
    }
}