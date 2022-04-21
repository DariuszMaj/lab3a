

using System;

namespace lab3a.Logger
{
    class ConsoleLogger : WriterLogger
    {

        public ConsoleLogger() { }


        public override void Log(params string[] messages)
        {
            foreach(string a in messages)
            {
                Console.Write(a);
            }
            Console.WriteLine();

        }









        public override void Dispose()
        {
            
        }
    }
}
