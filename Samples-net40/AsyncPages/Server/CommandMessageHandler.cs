using Messages;
using NServiceBus;
using System.Threading;
using System;

namespace Server
{
    public class CommandMessageHandler : IHandleMessages<Command>
    {
        public IBus Bus { get; set; }

        public void Handle(Command message)
        {
            Thread.Sleep(TimeSpan.FromSeconds(1));

            if (message.Id % 2 == 0)
                Bus.Reply<CommandReply>(t => { t.Message = "Bla pari" + message.Id; });
            //    Bus.Return(ErrorCodes.Fail);
            else
                Bus.Reply<CommandReply>(t => { t.Message = "Bla dispari" + message.Id; });
            //Bus.Return(ErrorCodes.None);
        }
    }
}
