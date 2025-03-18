using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    interface IKrediManager
    {

        //Hepsi hesaplama yapacak ama içeriği farklı bu tür durumlarda class DEĞİL INTERFACE olur artık o 
        //Okunurluğu arttırmak için I harfi ile başlarlar
        //Şablon görevi görüyor
        //Biri bu interface i kullanırsa o bu methodları içermek zorunda , 
        public void Hesapla();
        public void BiseyYap();



    }
}
