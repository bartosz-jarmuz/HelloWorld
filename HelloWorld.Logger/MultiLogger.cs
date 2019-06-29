using System.Collections.Generic;
using HelloWorld.Contracts;

namespace HelloWorld.Loggers
{
    public class MultiLogger : ILogger
    {
        private readonly IReadOnlyCollection<ILogger> loggers;

        public MultiLogger(params ILogger[] loggers)
        {
            var list = new List<ILogger>();
            foreach (ILogger logger in loggers)
            {
                list.Add(logger);
            }

            this.loggers = list.AsReadOnly();
        }

        public void Log(string message)
        {
            foreach (ILogger logger in this.loggers)
            {
                logger.Log(message);
            }
        }
    }
}