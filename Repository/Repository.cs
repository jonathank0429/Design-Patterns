using Design_Patterns_Assignment;

using System;
using System.Collections.Generic;

namespace Design_Patterns_Assignment
{
    internal class Repository
    {
        internal static void Run()
        {
            // Refactor this code so that it uses the Repository Pattern
            Console.WriteLine("Repository");

            List<Customer> customers = new List<Customer>();
            List<Animal> animals = new List<Animal>();
            customers.Add(new Customer("Steve"));
            animals.Add(new Animal("Dog", "Steve"));

            var customer = customers.Find(x => x.Name == "Steve");
            var animal = animals.Find(x => x.OwnerName == "Steve");
            Console.WriteLine(customer.Name);
            Console.WriteLine(animal.Name);


            /*var data = SimulatedDatabase.Load("Dataset A");
            var customer = SimulatedDatabase.Load("From Table Customer Where Name==Steve"); // this is a search
            var animal = SimulatedDatabase.Load("From Table Animal Where Owner==Steve"); // this is a search
            SimulatedDatabase.Save(data);
            SimulatedDatabase.Save(customer);
            SimulatedDatabase.Save(animal);
            Console.WriteLine();*/
        }
    }
}