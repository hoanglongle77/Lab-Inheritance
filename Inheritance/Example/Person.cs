using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Example
{
    internal class Person
    {
        private string name;
        private string address;

        public string Name { get => name; set => name=value; }
        public string Address { get => address; set => address=value; }

        public Person()
        {
        }

        public Person(string name, string address)
        {
            Name=name;
            Address=address;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Name: {Name}, Address: {Address}");
        }

        public override string? ToString()
        {
            return $"Name: {Name}, Address: {Address}";
        }
    }
}
