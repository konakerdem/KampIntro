﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    public class SepetManager
    {
        

        //naming convention

        public void Ekle(Urun urun)
        
        {
            Console.WriteLine("Tebrikler.Sepete Eklendi : "+urun.Adi); 

        }

        //kötü yöntem
        //yeni bir parametre ekleneceği zaman gelip eklemen lazım.
        public void Ekle2(string urunAdi,string aciklama,double fiyat)
        {

            Console.WriteLine("Tebrikler.Sepete eklendi : "+urunAdi);
        }

     
    }
}
