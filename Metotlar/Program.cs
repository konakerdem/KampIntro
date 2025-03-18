using System;

namespace Metotlar
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";


            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";


            Urun[] urunler = new Urun[] { urun1, urun2};

            //type-safe tip güvenli

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);    
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------");

            }

            Console.WriteLine("-------METOTLAR-------");

            //instance - örnek

            //ENCAPSULATION-KAPSÜLLEME  Oluşturulan bir sınıf (class) içerisinde kullanıcının işlemlerini daha kolay gerçekleştirebilmesi için
            //bazı işlemler birleştirilerek tek bir işlem gibi gösterilir. AŞAĞIDAKİ GİBİ DÜZENSZ OLACAĞINA BÖYLE DÜZENLİ   
            
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            //kötü yöntem
           //yeni bir parametre ekleneceği zaman tüm kod satırlarına tek tek eklemen lazım.
            sepetManager.Ekle2("Armut", "Yeşil Armut", 12);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12);


        }
    }
}


//Dont Repeat Yourself - DRY- Clean Code - Best Practice
