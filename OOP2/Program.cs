using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Sedat";
            musteri1.Soyadi = "KOÇ";
            musteri1.TcNo = "12345678932";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "2566445";
            musteri2.SirketAdi = "zeryaSoft";
            musteri2.VergiNo = "26365566555";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
        }
    }
}
