using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPROJECT_TQ.Delegates
{
    internal class DelegatesandEventscs
    {
        using System;
using EventandDelegates.Logs;
using EventandDelegates.Message;
namespace EventandDelegates
    {
        class Program
        {
            static void Main(string[] args)
            {
                LogEvent logEvent = new LogEvent();
                EmailMessage emailMessage = new EmailMessage();
                TextMessage textMessage = new TextMessage();


                emailMessage.Emailed += logEvent.OnMailed;
                textMessage.Texted += logEvent.OnTexted;

                emailMessage.Send();
                textMessage.Send();
            }
        }
    }
}
}
