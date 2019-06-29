using System;
using HelloWorld.Contracts;

namespace HelloWorld.ConsoleApp.Utilities
{
    class CalculationTypeProvider
    {
        private static readonly string MultiplyOperationName = "Multiply";
        private static readonly string DivideOperationName = "Divide";
        private static readonly string PowerOperationName = "Power";

        public CalculationType GetCalculationType()
        {
            Console.WriteLine("Provide calculation name:");
            string calculationName = Console.ReadLine();
            if (String.Equals(calculationName, DivideOperationName, StringComparison.OrdinalIgnoreCase))
            {
                return CalculationType.Division;
            }
            else if (String.Equals(calculationName, MultiplyOperationName, StringComparison.OrdinalIgnoreCase))
            {
                return CalculationType.Multiplication;

            }
            else if (String.Equals(calculationName, PowerOperationName, StringComparison.OrdinalIgnoreCase))
            {
                return CalculationType.Power;
            }

            return CalculationType.Unrecognized;

        }

    }
}