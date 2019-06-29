using System;
using System.IO;
using HelloWorld.Contracts;

namespace HelloWorld.Loggers
{
    public class TextLogger : ILogger
    {
        public TextLogger()
        {
            string fileName = DateTime.Now.ToString("yyyy-MM-dd hh-mm-ss") + "_Log.txt";
            logFile = new FileInfo(Path.Combine(Directory.GetCurrentDirectory(), fileName));
        }

        private FileInfo logFile;

        public virtual void Log(string message)
        {
            try
            {
                File.AppendAllText(logFile.FullName, message + Environment.NewLine);
            }
            catch (Exception)
            {
                //how to handle it....?
                //well, at least do not throw an error.
                //loggers etc should not crash applications they support
            }
        }
    }
}
