using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empty.Classes
{
    class Shape
    {
        internal double Square { get; set; }
        public void PrintSquare()
        {
            Console.WriteLine($"Square = {Square};");
        }
    }
}
