using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Notifier : INotifier
    {
        public Notifier(string smtpServer, int port, string senderAddress, string senderPassword)
        {
            SmtpServer = smtpServer;
            Port = port;
            SendAddress = senderAddress;
            SendPassword = senderPassword;
        }

        public string SmtpServer {get;}
        public int Port {get;}
        public string SendAddress {get;}
        public string SendPassword {get;}

        public void Notify(string email, string subject, string body)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"You've a new email from `{SendAddress}` with subject `{subject}`");
            Console.WriteLine(body);
            Console.WriteLine($"Message sent successfully to `{email}`");
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}