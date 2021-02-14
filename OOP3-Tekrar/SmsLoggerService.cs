using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3_Tekrar
{
    class SmsLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Sms Loglandı");
        }
    }
}
