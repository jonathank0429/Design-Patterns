using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Observer
{
    public class Observer : IObserver
    {
        public string Email { get; set; }
        public Observer(string email, ISubject subject)
        {
            Email = email;
            subject.RegisterObserver(this);
        }

        public void update(string newuser)
        {
            Console.WriteLine("Hello " + Email + ", a new customer just registed with email:" + newuser);
        }
    }
}
