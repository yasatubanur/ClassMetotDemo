using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            musteri.Id = 1111111;
            musteri.Ad = "Tuba Nur";
            musteri.Soyad = "YASA";
            Console.WriteLine("müsteri eklendi.");
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine("musteri Id =" + musteri.Id);
            Console.WriteLine("musteri Ad = " + musteri.Ad);
            Console.WriteLine("musteri Soyad= " + musteri.Soyad);
        }

        public void Sil()
        {
            Console.WriteLine("Musteri silindi.");
        }
    }
}
