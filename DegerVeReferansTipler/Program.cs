﻿using System;

namespace DegerVeReferansTipler
{
    internal class Program
    {

        //stack-heap 
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;

            sayi1 = sayi2;   
            sayi2 = 65;
            
            // sayi1 ? 30 olurdu
        

            int[]sayilar1= new int[] { 10, 20, 30 };

            int[] sayilar2 = new int[] { 100, 200, 300 };

            sayilar1 = sayilar2;              
            sayilar2[0] = 999;                
                
            
            // sayilar1 [0 ]  ????    99 olurdu çünkü diziler referans tiplidir sayilar1[0] sayilar2[0] 'ın değerini değil adresini tutuyor
            // adresindeki depğeri de sonradan değiştirmişizi değişir bu sefer


            //int,decimal,float,double,bool   değer tip
            //array,class,interface           referans tip
         

        }
    }
}
