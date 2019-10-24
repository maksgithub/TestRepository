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
            Order order1 = new Order();
            order1.Print();

            Console.WriteLine(order1.Count);
            Console.WriteLine(order1._number);
            Console.Read();
        }
    }
}
