using System;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            //TEK SATIRDA TANIMLAMA
            Product product2 = new Product { Id = 2, CategoryId = 5, ProductName = "Kalem", UnitsInStock = 5 ,UnitPrice=35};
            
            //PascalCase   //camelCase
            //case sensitive

            ProductManager productManager = new ProductManager();

            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);
           




            //int,double,bool... değer tip
            //diziler,class,abstract class,interface referans tip
            //ref out 



















            /*
          int sayi1 = 100;
          productManager.BiseyYap(sayi1); //productManager.BiseyYap(100); demişim gibi çalışıyor yani
          Console.WriteLine(sayi1); // sayi1 içerde değişti ama biz burda fonksdan gelen değere eşitleme yapmadık o yüzden sadece fonks içinde değişti.(ayrıca returnlemeliydik)
          */




        }
    }
}
