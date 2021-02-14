using System;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {

            IKrediManager ihtiyacKredisi = new IhtiyacKrediManager();
            IKrediManager tasitKredisi = new TasitKrediManager();
            IKrediManager konutKredisi = new KonutKrediManager();


            BasvuruManager basvuru1 = new BasvuruManager();
            BasvuruManager basvuru2 = new BasvuruManager();
            basvuru1.BasvuruYap(ihtiyacKredisi);
            basvuru2.BasvuruYap(konutKredisi);
            basvuru1.BasvuruYap(konutKredisi);
             
        }
    }
}
