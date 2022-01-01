using AutoFacDemo.BusinessLogic.Interfaces;

namespace AutoFacDemo.BusinessLogic.Classes
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string content)
        {
            System.Console.WriteLine($"Logging {content}");
        }
    }
}
