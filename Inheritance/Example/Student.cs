using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Example
{
    internal class Student : Person
    {
        private string school;

        public string School { get => school; set => school=value; }

        public Student()
        {
        }

        public Student(string name, string address) : base(name, address)
        {
        }

        public Student(string name, string address, string school) : base(name, address)
        {
            School = school;
        }

        public override void Print()
        {
            Console.WriteLine($"Name: {Name}, Address: {Address}, School: {School}");
        }
    }
}
