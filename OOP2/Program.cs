using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ERDEM KONAK
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 11;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Erdem";
            musteri1.SoyAdi = "Konak";
            musteri1.TcNo = "11111111111";


            //KODLAMA.IO


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";




            //    Musteri musteri=new Musteri();     !!!! DİKKATTT  bu durumda sadece  kendisindekilere yani ortaklara  erişebiliyo 


            //   !!!!!!!!   Musteri classı üzerinden hem Gerçek Müşteri hem de Tüzel Müşteri'nin referansını tutabiliyor.


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            //  POLYMORPHISZM

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            //ekle fonksiyonu musteri nesnesi istiyor . Musteri hem gerçek hemde tüzel referansları tutabildiği için GERÇEK VEYA TÜZEL MMÜŞTERİ de gönderebiliyoruzzz 









            //SOLID
        }

    }

}
