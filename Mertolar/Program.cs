using System;

namespace Mertolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urundur urun1 = new Urundur();
            urun1.Id= 12983543;
            urun1.Adi = "Armut";
            urun1.Fiyati= 1.69;
            urun1.Aciklama = "Sulu sulu armutlar bunlar...";

            Urundur urun2 = new Urundur();
            urun2.Id = 138354645;
            urun2.Adi = "Ayva";
            urun2.Fiyati = 1.75;
            urun2.Aciklama = "Ekşi ayvalar var.";

            Urundur urun3 = new Urundur();
            urun3.Id = 1582497654;
            urun3.Adi = "Çikolata";
            urun3.Fiyati = 2.78;
            urun3.Aciklama = "Yedikçe yiyesi gelir insanın.";

            Urundur urun4 = new Urundur();
            urun4.Id = 521575848;
            urun4.Adi = "Bisküvi";
            urun4.Fiyati = 1.11;
            urun4.Aciklama = "paket paket götürün.";

            Urundur urun5 = new Urundur();
            urun5.Id = 1459734864;
            urun5.Adi = "Baklava";
            urun5.Fiyati = 10.19;
            urun5.Aciklama = "paket yaptırabilirsiniz...";
            Urundur[] urunler = new Urundur[] { urun1, urun2, urun3, urun4, urun5 };
            foreach (Urundur urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati+"$");
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("********************************************");
            }
            Console.WriteLine("***********************************Mertolar******************************************");
            SepetTarifi sepetTarifi = new SepetTarifi();
            sepetTarifi.Ekle(urun1);
            sepetTarifi.Ekle(urun2);
            sepetTarifi.Ekle(urun3);
            sepetTarifi.Ekle(urun4);
            sepetTarifi.Ekle(urun5);
            sepetTarifi.Ekle2("Çilek","Tatlı Çilek",1.12,10);
            sepetTarifi.Ekle2("Elma", "Yeşil Elma", 1.44,14);
            sepetTarifi.Ekle2("Dondurma", "Dondurmam kaymak", 1.59,25);
            sepetTarifi.Ekle2("Mantar", "Şifa", 2.66,29);
            sepetTarifi.Ekle2("Hazır Çorba", "pişirdiğinde mis gibi kokar", 0.89,17);
        }
    }
}
