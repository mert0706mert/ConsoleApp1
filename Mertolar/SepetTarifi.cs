using System;
using System.Collections.Generic;
using System.Text;

namespace Mertolar
{
    class SepetTarifi
    {
        public void Ekle(Urundur urun) 
        {
            Console.WriteLine("Tebriler. Sepete eklendi : "+urun.Adi);
        }
        public void Ekle2(string urunAdi,string aciklama, double fiyat,int stokAdedi)
        {
            Console.WriteLine("Tebriler. Sepete eklendi : " + urunAdi);
        }
    }
}
