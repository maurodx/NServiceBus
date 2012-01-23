using System;
using System.Threading;
using NServiceBus;
using NServiceBus.Host;

namespace MyClient
{
    public class EndpointConfig : IConfigureThisEndpoint, AsA_Client { }

    public class Program
    {
        private static IBus bus;

        public static void Main()
        {
            var host = new SelfHost();
            host.Start(new string[]{});

        //    try
        //    {


        //      bus=  NServiceBus.Configure.With(AllAssemblies.Except("NServiceBus.Host.exe")) //for web apps this should be WithWeb()
        //.Log4Net()
        //.DefaultBuilder()

        //.XmlSerializer()
        //.MsmqTransport()
        //.UnicastBus().DoNotAutoSubscribe()
        //    .LoadMessageHandlers()
        //.CreateBus()
        //.Start();
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //    bool stop = false;
        //    var cli = new ClientEndpoint();
        //    cli.Bus = bus;
        //    cli.Run();
        //    do
        //    {
        //        Thread.Sleep(5);
        //      //  var key = Console.ReadKey();
        //      //  if (key.Key == ConsoleKey.A)
        //      //      stop = true;
        //    } while (!stop);
        }
    }
}