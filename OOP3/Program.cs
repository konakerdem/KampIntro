using System;
using System.Collections.Generic;
//program.cs
namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            ihtiyacKrediManager.Hesapla();


            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            tasitKrediManager.Hesapla();

            KonutKrediManager konutKrediManager = new KonutKrediManager();
            konutKrediManager.Hesapla();
            */


            // -----------------DİKKATTT------  Interfaceden türetiyoruz ----------------------------


            //Interfacelerde de  ımplemente eden classların referansını tutaibliyor.


            //ben adreslerimi oluşturdum
            IKrediManager ihtiyacKrediManager2 = new IhtiyacKrediManager();

            IKrediManager tasitKrediManager2 = new TasitKrediManager();

            IKrediManager konutKrediManager2 = new KonutKrediManager();



            BasvuruManager basvuruManager = new BasvuruManager();
            /*hangini istersem parametre olarak onu gönderebilirim, ben hepsin i çalıştırıyım
            basvuruManager.BasvuruYap(ihtiyacKrediManager2);
            basvuruManager.BasvuruYap(tasitKrediManager2);
            basvuruManager.BasvuruYap(konutKrediManager2);
            */





            //---------Liste gönderme ---------------------
            /*

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager2, tasitKrediManager2 };

            basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            */



            //Loglama 

            //böyle yapıp içine yazailbirdik 
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileKrediManager = new FileLoggerService();

            //içeride referans oluşturma
            basvuruManager.BasvuruYap(new IhtiyacKrediManager(), new List<ILoggerService>() { new DatabaseLoggerService(), new FileLoggerService() });








        }
    }
}
