using System;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Engin Demiroğ
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "12345678910"; 


            //Kodlama.io

            TuzelMusteri musteri2=new TuzelMusteri();
            musteri2.Id=2;
            musteri2.MusteriNo="54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "12345678910";

            //Gerçek Müşteri - Tüzel Müşteri bunlar benziyo diye aynı nesneyi kullanma
            //SOLID   L HARFI 


            //Musteri gerçek musteride de adres oluşturabiliyor tuzelmusteride de adres oluşturabiliyor.

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();




              
            MusteriManager musteriManager = new MusteriManager();

            //Ekle fonksiyonu Musteri referansı istiyordu ama Musteri diğerlerinin de türebiliyor
            //Bu yüzden türetebildiklerini de kullanabiliyoruz.
            musteriManager.Ekle(musteri1);  
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);






        }
    }
}
