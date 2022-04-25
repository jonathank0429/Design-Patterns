using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Observer
{
    public class Subject : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private string Email { get; set; }

        public Subject(string email)
        {
            Email = email;
        }

        public void RegisterObserver(IObserver observer)
        {
            Console.WriteLine("Observer added: " + ((Observer)observer).Email);
            observers.Add(observer);
        }

        public void AddObservers(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            Console.WriteLine("Email Registed: " + Email);

            Console.WriteLine();
            foreach (IObserver observer in observers)
            {
                observer.update(Email);
            }
        }
    }
}
