using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab3a.Logger;

namespace lab3a
{
    public interface ILogger : IDisposable
    {
       
        void Log(params String[] messages);
    }
}
