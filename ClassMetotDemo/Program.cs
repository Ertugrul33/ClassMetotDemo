using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "DEMİROĞ";
            musteri1.Telefon = 5555555555;
            musteri1.Email = "engindemirog@gmail.com";

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Ertuğrul";
            musteri2.Soyadi = "EŞOL";
            musteri2.Telefon = 6666666666;
            musteri2.Email = "ertugrul.esol@gmail.com";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            MusteriManager musteriManager = new MusteriManager();
            foreach (var musteri in musteriler)
            {
                musteriManager.Ekle(musteri);
                Console.WriteLine("---------------------------");

            }
            Console.WriteLine("Müşteriler:");
            foreach (var musteri in musteriler)
            {
                musteriManager.Listele(musteri);
            }

            Console.WriteLine("---------------------------");

            foreach (var musteri in musteriler)
            {
                musteriManager.Sil(musteri);
                Console.WriteLine("---------------------------");
            }
        }
    }
}
