
using System.Text;
using System.IO;
using System;
using System.Threading.Tasks;

namespace lab3a.Logger
{
    public  class FileLogger : WriterLogger, ILogger
    {
        private bool disposed=false;
        protected FileStream Stream;
        private string Path;

        public FileLogger(string path) { Path = path; }

        public FileLogger() { }



        public override void Log(params string[] messages)
        {
            if (!File.Exists(Path))
                using (Stream = File.Create(Path))
                {
                    using (writer = new StreamWriter(Stream, Encoding.UTF8))
                    {
                        base.Log(messages);
                    }
                }
            else 
                using(Stream= new FileStream(Path,FileMode.Append))
                {
                    using(writer= new StreamWriter(Stream,Encoding.UTF8))
                    {
                        base.Log(messages);
                    }
                }

        }

        public override void Dispose()
        {
          
        }
    }
}
