using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{

    //Indivusual
    //Miras Inheritance
    internal class GercekMusteri:Musteri 
   //gerçek müşteri de bir müşteridir
   //Müşteride olan özellikler gerçek müşteride de vardır
    {
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }

    }
}
