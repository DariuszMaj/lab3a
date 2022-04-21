using System;
using System.IO;
using System.Text;
using lab3a.Logger;
namespace lab3a
{
    class Program
    {
        public static void Main()
        {

            ILogger[] loggers = new ILogger[]
            {
                new ConsoleLogger(),
                new FileLogger("log.txt"),
               // new SocketLogger("google.com", 80)
            };

            using (ILogger logger = new CommonLogger(loggers))
            {
                logger.Log("Example message 1 ...");
                logger.Log("Example message 2 ...");
                logger.Log("Example message 3 ...", "value 1", "value 2", "value 3");
            }


            //TextWriter writer;

            //// when we want to write text into file:
            //{
            //    FileStream stream = new FileStream("file.txt", FileMode.Append);

            //    writer = new StreamWriter(stream, Encoding.UTF8);
            //    writer.Write("Text to write here ...");
            //    writer.Flush();
            //}
            //    //string host = "google.com";
            //int port = 80;

            //using (ClientSocket clientSocket = new ClientSocket(host, port))
            //{
            //    // request:

            //    string requestText = "Message to sent ...";
            //    byte[] requestBytes = Encoding.UTF8.GetBytes(requestText);

            //    clientSocket.Send(requestBytes);

            //    // response:

            //    byte[] responseBuffer = new byte[1024];
            //    int responseSize = clientSocket.Receive(responseBuffer);

            //    string responseText = Encoding.UTF8.GetString(responseBuffer, 0, responseSize); // received message

            //    //...

            //    // cleaning:

            //    clientSocket.Close();


            //}



        }
    }
}

