using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class BasvuruManager
    {
        //Method Injection
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        //IkrediM tümmm referansları tutabiliyoooooo o yüzden referans olarak onu yazcammm
        //Birden fazla loglama  seçenğiolaiblir

        {
            // Başvuran bilgilerini değerlendirme

            krediManager.Hesapla();

            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();

            }

        }


        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler) //Birden fazla kredi hakkında talep gelebilir. Liste kullanırız
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }



    }
}
