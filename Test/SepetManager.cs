using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi --> " + urun.ProductName );
        }

        public void SepettenCikar(Urun urun)
        {
            Console.WriteLine("Sepetten Çıkarıldı  " + urun.ProductName + " : " + urun.Fiyat);
        }
    }
}
