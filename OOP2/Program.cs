using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri() ;
            musteri1.Id = 5;
            
            
            
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            

        }
    }
}
