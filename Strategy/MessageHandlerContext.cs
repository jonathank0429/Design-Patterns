using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    public class MessageHandlerContext
    {
        private IMessageHandler MessageHandler;
        public void SetMessageHandler(IMessageHandler type)
        {
            this.MessageHandler = type;
        }
        public void SendMessage(string message)
        {
            MessageHandler.SendMessage(message);
        }
    }
}
