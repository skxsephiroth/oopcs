using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    class Rectangle
    {
        // attributes
        int length;
        int breadth;
        // properties
        public int Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }

        public int Area
        {
            get
            {
                return length * breadth;
            }
        }
        // methods
        public int GetArea()
        {
            return length * breadth;
        }
    }
}
