using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class ProductManager
    {
        /*
         
        int değer tipli çalışır
        biz sayının sadece değerini fonksiyona alabildik
        
        public void BiseyYap(int sayi)
        {
            sayi = 99;
        }

        */





        //nesneler referans tipli çalışırlar productın adresini de almış olduk
        public void Add(Product product)
        {

            Console.WriteLine(product.ProductName +" eklendi.");

        }

        public void Update(Product product)
        {

            Console.WriteLine(product.ProductName + " güncellendi.");

        }


        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2; 
            //değeri döndürür
        }

        public void Topla2(int sayi1, int sayi2) 
        {
            Console.WriteLine(sayi1+sayi2);
            
        }





    }
}
