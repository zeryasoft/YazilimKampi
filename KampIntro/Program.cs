using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Sedat";
            kurs1.IzlenmeOrani = 58;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Zerya";
            kurs2.IzlenmeOrani = 78;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "C++";
            kurs3.Egitmen = "Nihal";
            kurs3.IzlenmeOrani = 80;

            Kurs[] kurslar = new Kurs[3]{kurs1, kurs2, kurs3};

            foreach (Kurs kurs in kurslar)
                Console.WriteLine(kurs.KursAdi);
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
