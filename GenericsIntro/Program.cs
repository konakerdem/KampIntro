using System;

namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // MyList isimler = new MyList(); normalde böyle yapardık ama bu generic bir class

            MyList<string> isimler = new MyList<string> ();
            isimler.Add("Erdem");
            


             
        
        }

    }
}
