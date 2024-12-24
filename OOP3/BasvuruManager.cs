using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BasvuruManager
    {
        //Herkesin referansını tutabilen IKredi manager alırım.İstek ne gelirse o obje çalışır 

        /*public void BasvuruYap(IKrediManager krediManager , ILoggerService loggerService)
        {
                //Başvuran bilgilerini değerlendirme
                //
                krediManager.Hesapla();
                loggerService.Log();//hangi parametreyle longlandıysa onu seç

        }
        */

        //birden fazla loglama türü olabilir

        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService> loggerService)
        {
            //başvuran bilgilerini değerlendirme
            krediManager.Hesapla();
            foreach (var logger in loggerService)
            {
               
                logger.Log();   
                
            }

        }



        //birden fazla şey hakkında bilgi talep edebiliriz
        public void KrediOnBilgilendirmesiYap(List<IKrediManager>krediler)
        {
            //üsttekiyle aynı sadece artık birden fazla aldığımız için dizi döngüsü yapıyoruz IKrediManager nesnelerimize
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();  
            }


        }




    }
}
