using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T>
    {
        //ben mylistimde T ile çalışacağım sen bana ne verirsen onla çalışcam List<string> List<int> gibi





        T[] items;

        //ctor tab tab  constructor 
        //classı newlediğinde otomatik çalışır
        public MyList()
        {
            items = new T[0];    //dizi classı newlediğimde oluşsun  , her başladığımda 0 elemanlı olarak newlenmiş olur 
        } 

        //bana hangi türde elemean vermek istiyosan o türde istiyorum
        public void Add(T item)
        {

            T[] tempArray=items; //geçici dizi    geçici dizinin referansı items dizisinin referansına eşitleniyor eski elemanlarım burada kaybetmemiş oldum

            items=new T[items.Length+1];

            //bir şey eklemek istediğimde dizimin eleman sayısını 1 arttırıyorum artık 1 elamanlı dizi oluyor
            //ama newlediğinde referans numarası yenileniyodu ve eski elemanları KAYBEDİYODUUKKK o yüzden GEÇİCİ DİZİ ile o REFERANSI tutuyoruz 

            //emanet verdiğmiz elemanları geri istiyorum

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; //sırasıyla kendi üzerime alıyorum.
            }

            items[items.Length - 1]=item;  // sonradan eklediğimiz item ı da sona ekledik


        }




    }
}
