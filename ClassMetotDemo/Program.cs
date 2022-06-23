using System;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Mem Robin";
            musteri1.Soyadi = "Çen";
            musteri1.Id = 202201;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Ahmet";
            musteri2.Soyadi = "Yılmaz";
            musteri2.Id = 202202;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Remove(musteri2);

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşteri No: " + musteri.Id);
                Console.WriteLine("Müştedi Adı: " + musteri.Adi);
                Console.WriteLine("Müşteri Soyadı: " + musteri.Soyadi);
            }
        }
    }
}
