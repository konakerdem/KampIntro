using System;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";

            //array-dizi
            
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı" , "Programlamaya başlangıç için temel kurs","Java","Python"};


            for (int i = 0; i < kurslar.Length; i++)
            {

                Console.WriteLine(kurslar[i]);
                
            }


            Console.WriteLine("for sonu ");

            
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
                
            }

            Console.WriteLine("Sayfa Sonu - Footer");
    

        }
    }
}
