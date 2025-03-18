using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class TasitKrediManager : IKrediManager //ımplement ınterface de tüm methodları getirsin
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            // ....

            Console.WriteLine("Taşıt Kredisi Ödeme Planı Hesaplandı");
        }
    }
}
