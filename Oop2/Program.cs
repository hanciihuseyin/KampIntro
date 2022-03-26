// See https://aka.ms/new-console-template for more information

using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo= "12345";
            musteri1.Adi = "Hüseyin;";
            musteri1.Soyadi = "Hancı";
            musteri1.TcNo = "12345678910";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Garip Yapım";
            musteri2.VergiNo = "1234567890";

        
        }
    }
}
