using System;
using System.Threading;
using NServiceBus;
using NServiceBus.Host;

namespace MyServer
{
    public class EndpointConfig : IConfigureThisEndpoint, AsA_Server { }

    public class Program
    {
        private static IBus bus;

        public static void Main()
        {
            var host = new SelfHost();
            host.Start(new string[] { });
         //   try
         //   {


         //       bus = NServiceBus.Configure.With(AllAssemblies.Except("NServiceBus.Host.exe")) //for web apps this should be WithWeb()
         //.Log4Net()
         //.DefaultBuilder()

         //.XmlSerializer()
         //.MsmqTransport()
         //.UnicastBus()
         //    .LoadMessageHandlers()
         //.CreateBus()
         //.Start();
         //   }
         //   catch (Exception)
         //   {

         //       throw;
         //   }

         //   bool stop = false;
         //   do
         //   {
         //       Thread.Sleep(5);
         //       //var key=Console.ReadKey();
         //       //if (key.Key == ConsoleKey.A)
         //       //    stop = true;
         //   } while (!stop);
        }
    }
}