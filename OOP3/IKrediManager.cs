using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{

    //içerisi farklı ama hesaplama işlemi yapacak yapılarda ana classı interface olarak tanımlıyoruz
    // Kalıtım yapacağın classlar aşağıda yer alan Fonksiyonları içermek ZORUNDA
    interface  IKrediManager //INTERFACE olduğu anlaşılsın diye I harfiyle başlatırız.
    {


         void Hesapla();
         void BiseyYap();

    }
}
