using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3_Tekrar
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager  , List<ILoggerService> loggerService)
        {
            
            krediManager.Hesapla();
            
            foreach ( var logManager in loggerService)
            {
                logManager.Log();   

            }

        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler , ILoggerService loggerService)
        {
            foreach ( var krediManager in krediler)
            {
                krediManager.Hesapla();
                
            }

     
        }
    }
}
