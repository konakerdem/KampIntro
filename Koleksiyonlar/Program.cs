using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //arraylerde eleman sayısı sabit kalıyor 
            string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };

            Console.WriteLine(isimler[0]); //Engin
            Console.WriteLine(isimler[1]); //Murat
            Console.WriteLine(isimler[2]); //Kerem
            Console.WriteLine(isimler[3]); //Halil


            isimler = new string[5]; //isimlerin artık adresi değişti yeni adres oluşturdum.
            isimler[4] = "İlker";

            Console.WriteLine(isimler[4]); //İlker
            Console.WriteLine(isimler[0]); //boş çünkü artık yeni adresin 0.indisi orası boş, biz 4.indise tanımlama yaptık.Önceki değerleri sonradan çağıramıyoruz. new den önce çağırabiliyoruz.



            //bunun önüne geçebilmek için KOLEKSİYONLAR kullanıyoruz


            /* tanımlamayı sonradan yaparken 
             
             List<string> isimler2= new List<string>();
            isimler2.Add("Engin"); 

            */

            List<string> isimler2 = new List<string> { "Engin", "MURAT", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);

            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]); //ilker eklendi
            Console.WriteLine(isimler2[0]); //önbekiler de kaybolmadı



        }
    }
}
