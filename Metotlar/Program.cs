using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Adi = "Forma";
            urun1.Fiyati = 289;
            urun1.Aciklama = "Çubuklu Forma";
            urun1.Id = 1;

            Urun urun2 = new Urun();
            urun2.Adi = "T-Shirt";
            urun2.Fiyati = 79;
            urun2.Aciklama = "1907 Baskılı T-Shirt";
            urun2.Id = 2;

            
            
            
            
            
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
        
        
        
        }


    }
}
