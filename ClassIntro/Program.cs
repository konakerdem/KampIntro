﻿using System;

namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;



            Kurs kurs1= new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "JAVA";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "PYTHON";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 80;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Murat Kurtboğan";
            kurs4.IzlenmeOrani = 100;





            // Console.WriteLine(kurs1.KursAdi+" : "+kurs1.Egitmen); bunun yerine kurs tipinde dizide tutucam


            Kurs[] kurslar=new Kurs[] {kurs1,kurs2,kurs3};

            foreach (var kurs in kurslar)
            { //var da olabilir Kurs da olabilir parantez içi

                Console.WriteLine(kurs.KursAdi+" : "+kurs.Egitmen);
                Console.WriteLine(kurs.IzlenmeOrani+"%");   
              
            }

        } 

    }


    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }

        public int IzlenmeOrani { get; set; }


    }


}
