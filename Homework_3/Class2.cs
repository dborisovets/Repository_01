using ClassLibrary_Human;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    internal class Employee:Human
    {
        private string position;
        public int retirementAge = 65;

        public Employee(string name, string position): base(name)
        {
            this.position = position;
        }

        public Employee(string position, int retirementAge)
        {
            this.position = position;
            this.retirementAge = retirementAge;
        }


        public string Position { get => position; set => position = value; }

        public void Print()
        {
            Console.WriteLine(position);
        }

        public void Work() { Console.WriteLine($"{Name} is working"); }

        public override void PrintShortInfo() => Console.WriteLine($"Name: {Name} position: {position}");

        public void CheckRetirementAge()
        {
            if (Age >= retirementAge)
                Console.WriteLine("already retired");
            else
                Console.WriteLine($"How many years untill retirement: {retirementAge - Age}");
        }
    }
}
