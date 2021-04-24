using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad = "Mert Çetinkaya";
            int yas = 20;
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "Java";
            kurs1.Egitmen = "Kerem Varış";
            kurs1.IzlenmeOrani = 86;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C#";
            kurs2.Egitmen = "Engin Demiroğ";
            kurs2.IzlenmeOrani = 70;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Mustafa Murat Coşkun";
            kurs3.IzlenmeOrani = 29;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Şadi Evren Şeker";
            kurs4.IzlenmeOrani = 45;

            Kurs kurs5 = new Kurs();
            kurs5.KursAdi = "C";
            kurs5.Egitmen = "Samet Akçalar";
            kurs5.IzlenmeOrani = 100;
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4, kurs5 };
            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+" : "+kurs.Egitmen+" : %"+kurs.IzlenmeOrani);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public double IzlenmeOrani { get; set; }
    }
}
