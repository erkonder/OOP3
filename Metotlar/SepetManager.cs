using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun) 
        {
            Console.WriteLine("Sepete Eklendi ---> " + " Ürün Adı : " + urun.Adi + "," + " Ürün Fiyatı : " + urun.Fiyati + "," +" Ürün Açıklaması : " + urun.Aciklama + "," +" Ürün Id " + urun.Id);        
        }
    }
}
