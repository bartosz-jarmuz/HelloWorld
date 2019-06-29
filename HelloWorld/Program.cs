using System;
using System.IO;
using HelloWorld.ConsoleApp.Utilities;
using HelloWorld.Contracts;
using HelloWorld.PremiumCalculations;

namespace HelloWorld.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Welcome to the calculating app");
            Console.BackgroundColor = ConsoleColor.Black;

            NumberProvider numberProvider = new NumberProvider();

            Tuple<int, int> numbers = numberProvider.GetNumbers();

            Console.WriteLine("Thanks. These will be fun to do maths on.");

            Console.WriteLine("Initializing calculator...");

            CalculationTypeProvider calculationTypeProvider = new CalculationTypeProvider();

            CalculationType calculationType = calculationTypeProvider.GetCalculationType();

            ICalculator calculator = CalculatorFactory.Get(calculationType);
            if (calculator != null)
            {
                Console.Beep();

                decimal result = calculator.Calculate(numbers.Item1, numbers.Item2);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Yay... The result is {result}. Bye bye.");
                Console.ReadKey();

            }
        }



        
    }
}
