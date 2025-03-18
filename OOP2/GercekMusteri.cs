using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //Individual
    class GercekMusteri : Musteri //inheritance
                                  //Müşteri de olan özellikler artık Gerçek Müşteride de vardır
    {

       
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string SoyAdi { get; set; }

    }
}
