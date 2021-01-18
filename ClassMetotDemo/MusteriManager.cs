using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi!!!");
            Console.WriteLine("Adi : " + musteri.Adi);
            Console.WriteLine("Soyadi : " + musteri.Soyadi);
            Console.WriteLine("Telefonu : " + musteri.Telefon);
            Console.WriteLine("E-Maili : " + musteri.Email);
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi!!!");
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi);
        }
    }
}
