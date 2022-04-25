using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    class Observer2
    {
        internal static void Run()
        {
            // Refactor this code so that it uses the Observer Pattern
            Console.WriteLine("Observer");
            Design_Patterns_Assignment.Observer.Subject newuser = new Design_Patterns_Assignment.Observer.Subject("newuser@gmail.com");
            Design_Patterns_Assignment.Observer.Observer user1 = new Design_Patterns_Assignment.Observer.Observer("admin@gmail.com", newuser);
            Design_Patterns_Assignment.Observer.Observer user2 = new Design_Patterns_Assignment.Observer.Observer("mod@gmail.com", newuser);
            Console.WriteLine();
            newuser.NotifyObservers();
            Console.Read();
            /* Console.WriteLine("Observer");
             var email = "";
             while (string.IsNullOrEmpty(email))
             {
                 email=Email.Check();
             }            
             Console.WriteLine(email);
             Console.WriteLine();*/
        }
    }
}
