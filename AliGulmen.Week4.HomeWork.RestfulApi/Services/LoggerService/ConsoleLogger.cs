using System;

namespace AliGulmen.Week4.HomeWork.RestfulApi.Services.LoggerService
{
    public class ConsoleLogger : ILoggerService
    {
     
        public void Log(string message)
        {
            Console.WriteLine("[ConsoleLogger] - " + message);
        }
    }
}
