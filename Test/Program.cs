using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun() ;
            urun1.ProductName = "Forma";
            Urun urun2 = new Urun();
            urun2.ProductName = "T-Shirt";
            urun2.Fiyat = 89;


            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.SepettenCikar(urun2);

        }
    }
}
