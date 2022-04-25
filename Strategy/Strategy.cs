using System;

namespace Design_Patterns_Assignment
{
    internal class Strategy
    {
        //KLAR
        internal static void Run()
        {
            Console.WriteLine("Strategy");
            Console.WriteLine("Enter message type : SMS | Email | FacebookMessage: ");
            string messagetype = Console.ReadLine();
            Console.WriteLine("Message type is : " + messagetype);
            Console.WriteLine("Enter message: ");
            string message = Console.ReadLine();

            MessageHandlerContext context = new MessageHandlerContext();
            if ("SMS".Equals(messagetype, StringComparison.InvariantCultureIgnoreCase))
            {
                context.SetMessageHandler(new SMSStrategy());
            }
            else if ("Email".Equals(messagetype, StringComparison.InvariantCultureIgnoreCase))
            {
                context.SetMessageHandler(new EmailStrategy());
            }
            else if ("FacebookMessage".Equals(messagetype, StringComparison.InvariantCultureIgnoreCase))
            {
                context.SetMessageHandler(new FacebookMessageStrategy());
            }

            context.SendMessage(message);
            Console.ReadKey();
        }
    }
}