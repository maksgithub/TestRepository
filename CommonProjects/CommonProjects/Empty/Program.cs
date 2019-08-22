using Empty.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empty
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle(3, 4);
            Rectangle rect2 = new Rectangle(3, 4);
            Circle circ = new Circle(3);

            rect1.PrintSquare();
            rect2.PrintSquare();
            circ.PrintSquare();

            Console.Read();
        }
    }
}
