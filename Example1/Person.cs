using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    class Person
    {
        // attributes
        string name;
        int age;

        public Person()
        {
            age = 1;
            name = "";
        }
        public Person(string n)
        {
            age = 1;
            name = n;
        }
        public Person(string n, int a)
        {
            age = a;
            name = n;
        }
        // methods
        public int GetAge()
        {
            return age/365;
        }

        public void SetAge(int newvalue)
        {
            newvalue = newvalue * 365;
            if (newvalue > 0)
                age = newvalue;
            else
                Console.WriteLine("Age cannot be negative");
        }

        public int Age
        {
            get
            {
                return age / 365;
            }
            set
            {
                int newvalue = value * 365;
                if (newvalue > 0)
                    age = newvalue;
                else
                    Console.WriteLine("Age cannot be negative");
            }
        }
    }
}
