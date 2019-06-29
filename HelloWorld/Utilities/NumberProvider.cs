using System;

namespace HelloWorld.ConsoleApp.Utilities
{
    class NumberProvider
    {
        public Tuple<int, int> GetNumbers()
        {
            Console.WriteLine("Provide first number");
            int firstNumber = GetNumber();

            Console.WriteLine("Provide second number");
            int secondNumber = GetNumber();
             
            return new Tuple<int, int>(firstNumber, secondNumber);
        }

        private int GetNumber()
        {
            string input = Console.ReadLine();
            return Int32.Parse(input);
        }
    }
}