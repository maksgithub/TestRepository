using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Window_Price_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press E for exit");
            Console.WriteLine("Press A for about");
            string key = "a";
            bool x = key == "a";
            while (x)
            {
                key = Console.ReadLine();
                if (key == "e")
                {
                    break;
                }
                if (key == "a")
                {
                    Console.WriteLine("Project name version 1.0");
                    Console.ReadKey();
                }
                x = key != "a";
            }
        }
    }
}