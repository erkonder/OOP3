using System;

namespace OOP3_Tekrar
{
    class FileLoggerSevice : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya Loglandı");
        }
    }
}
