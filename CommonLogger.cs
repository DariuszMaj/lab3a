using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace lab3a.Logger
{
   internal class CommonLogger: ILogger
    {
        private  ILogger[] Loggers;
       
        public CommonLogger(ILogger[] loggers) { Loggers = loggers; }
         void IDisposable.Dispose()
        { 
            foreach(ILogger check in Loggers)
            {
                check.Dispose();
            }
        }
       
        void ILogger.Log(params string[] messages)
        {
            DateTime myTime = DateTime.UtcNow;
           
            foreach (ILogger cases in Loggers)
            {
                
                cases.Log(messages.Prepend(myTime.ToString()).ToArray());
            }
      }
    }
}
