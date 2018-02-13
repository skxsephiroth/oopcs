using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{

    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.SetAge(10);
            Console.WriteLine(p1.GetAge());
            Person p2 = new Person();
            p2.Age = 34;
            Console.WriteLine(p2.Age);

            Coin c1;
            c1 = new Coin();
            Coin c2;
            c2 = new Coin();
            for (int i = 0; i < 10; i++)
            {
                c1.Flip();
                Console.WriteLine(c1.GetFace());
            }
        }
    }
}
