using System.Collections.Generic;
using System.Linq;

namespace Design_Patterns_Assignment
{
    public class Customer : ICustomer
    {
        public string Name { get; set; }

        public Customer(string name)
        {
            Name = name;
        }
    }
}