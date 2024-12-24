using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //Coorporate
    //Miras-Inheritance

    internal class TuzelMusteri:Musteri
    //Tuzel Müşteri bir müşteridir
    //Müşteride olan özellikler tüzel müşteride de vardır ortak olan Id Musteri No yu bu yüzden Musteriye yazıcam

    {
        //public int Id { get; set; }
        //public string MusteriNo { get; set; }
        public string SirketAdi { get; set; }   
        public string VergiNo { get; set; }

    }
}
