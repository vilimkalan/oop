using System;
using System.Collections.Generic;
using System.Text;

namespace LV5.classes2
{
    internal class ConsoleLogger
    {
        private static ConsoleLogger instance;

        
        private ConsoleLogger() { }

        public static ConsoleLogger Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ConsoleLogger();
                }
                return instance;
            }
        }

        public void Log(string message)
        {
            Console.WriteLine($"[LOG - {DateTime.Now:HH:mm:ss}]: {message}");
        }
    }
}
