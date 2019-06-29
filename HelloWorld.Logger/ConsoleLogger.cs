using System;
using HelloWorld.Contracts;

namespace HelloWorld.Loggers
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("TextLogger: " +message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}