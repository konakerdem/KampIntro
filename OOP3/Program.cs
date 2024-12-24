using System;
using System.Collections.Generic;
//program.cs
namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //yine Musterideki gibi IKrediManager dan diğerlerini türetebiliyoruz.Polymorphism
        
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager=new TasitKrediManager();
            IKrediManager konutKrediManager=new KonutKrediManager();



            ILoggerService databaseLoggerService=new DatabaseLoggerService();
            ILoggerService fileLoggerService=new FileLoggerService();   //BÖYLE DE GÖNDEREBİLİRİM  gönderirken de adresleyeiblirim aşağıda var 

            

            BasvuruManager basvuruManager = new BasvuruManager();
            /*tek loglama
             
            basvuruManager.BasvuruYap(tasitKrediManager, databaseLoggerService);
            
             */


            //PARTAMETRE GÖNDERİRKEN DE ADRES OLUŞTURABİLİRİM
            //birden fazla loglama seçme
            List<ILoggerService> loggers = new List<ILoggerService> {new SmsLoggerService(),new FileLoggerService() };

            basvuruManager.BasvuruYap(new EsnafKredisiManaager(),loggers); //loggers yerine orada da newlyebilirim ama temiz olsun artık .




            //Birden fazla kredi hakkında bilgi almak istiyorum.
            List<IKrediManager>krediler=new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager};
            // basvuruManager.KrediOnBilgilendirmesiYap(krediler); //krediler listesini parametre olarak gönderdim.


            string değişiklik = "erdem";


        }
    }
} 
