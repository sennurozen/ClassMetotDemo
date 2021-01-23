using System;
using System.Collections.Generic;
using System.Text;

namespace O0P3
{
    class DatabaseLoggerService:ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı");
        }
    }
}
