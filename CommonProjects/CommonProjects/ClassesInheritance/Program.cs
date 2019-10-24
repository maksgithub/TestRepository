using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesInheritance
{
    class Program
    { 
        static void Main(string[] args)
        {
            Shape shape1 = new Circle();
            Shape shape2 = new Rectangle(4);

            Console.WriteLine(shape1.Calculate());
            Console.WriteLine(shape2.Calculate());
            Console.WriteLine(shape3.Calculate());
            Console.ReadLine();
        }
    }
}
