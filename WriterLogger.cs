
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab3a.Logger
{
    public abstract class WriterLogger : ILogger
    {
       protected TextWriter writer;


        public virtual void Log(params string[] messages)
        {
            // Uzupełnić to miejsce o logikę zapisu opartą o TextWriter ...
            foreach (string a in messages)
            {
                writer.Write(a);

            }
            writer.Write(Environment.NewLine);
            writer.Flush();
        }

        public abstract void Dispose();
    }
}

