using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Example
{
    internal class Employee:Person
    {
        private string company;

        public string Company { get => company; set => company=value; }


        public Employee()
        {
        }

        public Employee(string name, string address) : base(name, address)
        {
        }

        public Employee(string name, string address,string company) : base(name, address)
        {
            Company = company;
        }

        public override void Print()
        {
            Console.WriteLine($"Name:{Name}, Address:{Address}, Company:{Company}"); ;
        }
    }
}
