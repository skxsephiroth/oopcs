using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library1;

namespace Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer("Tan Ah Kow", "3 Clementi Road");
            c.Print();
        }
    }
}
