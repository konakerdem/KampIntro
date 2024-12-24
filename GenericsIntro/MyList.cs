using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    //ben mylistimde T ile çalışacapım
    internal class MyList<T>
    {

        T[] items; //dizi oluştu ama adresi oluşmadı


        //constructor classı newlersen otomatik çalışıyor.

        public MyList()
        {
            items=new T[0]; //newlediğimiz anda dizi istenilen türde newlendi ve elemanı yok 0 elemanlı.

        }



        public void Add(T item)
        {
            T[] tempArray = items;  //geçici dizi.
            //dizinin uzunluğunu değiştirdiğimizde kaybolmasın diye eski verileri bu dizide tutuyoruz.

            items = new T[items.Length + 1];

            //önceki elemanları ekledik
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

             //son elemanına yeni değeri ekledik
            items[items.Length-1] = item;


        }



    }
}
