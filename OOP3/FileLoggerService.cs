using System;

namespace OOP3
{
    //aynı dosya içinde de Interface e bağlı classı tanımlayabilirsin

    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }
    }







}
