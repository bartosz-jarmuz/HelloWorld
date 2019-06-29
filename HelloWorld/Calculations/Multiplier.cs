using HelloWorld.Contracts;

namespace HelloWorld.ConsoleApp.Calculations
{
    class Multiplier : ICalculator
    {
        public decimal Calculate(decimal a, decimal b)
        {
            return a * b;
        }
    }
}