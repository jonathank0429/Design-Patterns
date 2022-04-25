using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    public class Animal : IAnimal
    {
        public string Name { get; set; }
        public string OwnerName { get; set; }

        public Animal(string name, string ownername)
        {
            Name = name;
            OwnerName = ownername;
        }
    }
}
