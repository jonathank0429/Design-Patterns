using System;

namespace Design_Patterns_Assignment
{
    /*internal class MessageHandler
    {
        internal static void SendEmail(string message)
        {
            Console.WriteLine($"sending \"{message}\" as an email");
        }

        internal static void SendSMS(string message)
        {
            Console.WriteLine($"sending \"{message}\" as a sms");
        }

        internal static void SendFacebookMessage(string message)
        {
            Console.WriteLine($"sending \"{message}\" as a facebookmessage");
        }
    }*/
    public class EmailStrategy : IMessageHandler
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"sending \"{message}\" as a email");
        }
    }

    public class SMSStrategy : IMessageHandler
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"sending \"{message}\" as a sms");
        }
    }

    public class FacebookMessageStrategy : IMessageHandler
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"sending \"{message}\" as a facebookmessage");
        }
    }
}