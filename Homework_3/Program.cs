﻿using ClassLibrary_Human;
using Client;
using System;
using System.Security.AccessControl;

namespace Company
{
    class BaseClass
    {
        static void Main()
        {
            Employee employee = new Employee("QA", "Dasha");
            Employee employee1 = new Employee("Devops", 50);
            employee.PrintShortInfo();
            Human[] persons = new Human[4];
            persons[0] = new Human("Dasha", "Borisovets", "female", 30 );
            persons[1] = new Human("Masha", "Fedorova", "female", 31 );

            persons[2] = new Human();
            persons[2].Name = "Pasha";
            persons[2].LastName = "Semashko";
            persons[2].Gender = "male";
            persons[2].Age = 32;

            persons[3] = new Employee("QA", 50);
            persons[3].Age = 40;
            persons[3].Gender = "male";
            persons[3].Name = "Ali";
            persons[3].LastName = "Baba";

            foreach (Human e in persons)
            {
                e.PrintShortInfo();
            }
        }
    }
}
