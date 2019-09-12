using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            Person max = new Person(name);

            max.SetName();

            max.Run(5);
            Console.ReadKey();
        }
    }
}
