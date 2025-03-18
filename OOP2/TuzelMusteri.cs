using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //Coorporate
    class TuzelMusteri : Musteri //inheritance
                                 //Müşteri de olan özellikler artık Tüzel Müşteride de vardır

    {

        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }

    }
}

