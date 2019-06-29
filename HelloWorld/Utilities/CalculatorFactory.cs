using System;
using System.Collections.Generic;
using HelloWorld.ConsoleApp.Calculations;
using HelloWorld.Contracts;
using HelloWorld.Loggers;
using HelloWorld.PremiumCalculations;

namespace HelloWorld.ConsoleApp.Utilities
{
    public static class CalculatorFactory
    {


        public static ICalculator Get(CalculationType type)
        {
            switch (type)
            {
                case CalculationType.Division:
                    return new Divider(new ConsoleLogger());
                case CalculationType.Multiplication:
                    return new Multiplier();
                case CalculationType.Power:
                    return new Powerizer(new MultiLogger(new TextLogger(), new ConsoleLogger()));
                default:
                    Console.WriteLine($"[{type}] is not a supported operation");
                    return null;
            }
        }


    }
}