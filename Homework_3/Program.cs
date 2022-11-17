using ClassLibrary_Employee;
using System;
using System.Security.AccessControl;

namespace Company
{
    class BaseClass
    {
        static void Main()
        {
            Employee[] persons = new Employee[4];
            persons[0] = new Employee("Dasha", "Borisovets", "female", 30, "QA");
            persons[1] = new Employee("Masha", "Fedorova", "female", 31, "BA");

            persons[2] = new Employee();
            persons[2].name = "Pasha";
            persons[2].lastName = "Semashko";
            persons[2].Gender = "male";
            persons[2].Age = 32;
            persons[2].Position = "PM";

            persons[3] = new Employee("Oleg", "Ivanov");
            persons[3].Age = 40;
            persons[3].Position = "QA";
            persons[3].Gender = "male";

            foreach (Employee e in persons)
            {
                e.PrintFullInfo();
            }
            persons[3].Work();

            persons[2].PrintShortInfo();
        }
    }
}
