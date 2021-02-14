using System;
using System.Collections.Generic;

namespace OOP3_Tekrar
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKredisi = new IhtiyacKredisiManager();
            IKrediManager tasitKredisi = new TasitKredisiManager();
            IKrediManager konutKredisi = new KonutKredisiManager();
            IKrediManager esnafKredisi = new EsnafKredisiManager();
            ILoggerService databaseLog = new DataBaseLoggerService();
            ILoggerService fileLog = new FileLoggerSevice();
            ILoggerService smsLog = new SmsLoggerService();
            
            BasvuruManager krediManager1 = new BasvuruManager();
            //krediManager1.BasvuruYap(ihtiyacKredisi , databaseLog );
            //krediManager1.BasvuruYap(tasitKredisi , fileLog);
            //krediManager1.BasvuruYap(esnafKredisi, smsLog);


            //List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKredisi ,tasitKredisi,konutKredisi ,esnafKredisi };
            //List<ILoggerService> loglar = new List<ILoggerService>() { fileLog, databaseLog, smsLog };

            //krediManager1.BasvuruYap(new IhtiyacKredisiManager(), loglar) ;
            krediManager1.BasvuruYap(new IhtiyacKredisiManager(), new List<ILoggerService> { new SmsLoggerService() , new FileLoggerSevice() , new DataBaseLoggerService() }); ;


            
        }
    }
}
 