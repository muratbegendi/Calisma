﻿using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Murat Beğendi

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Murat";
            musteri1.Soyadi = "Beğendi";
            musteri1.TcNo = "12345678910";

            //Kodlama.io

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "5465";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567896";


            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);


        }
    }
}
