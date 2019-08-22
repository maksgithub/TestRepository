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
            while (true)
            {
                string key = Console.ReadLine();
                if (key == "e")
                {
                    break;
                }
                if (key == "a")
                {
                    Console.Clear();
                    Console.WriteLine("Project name version 1.0");
                }
                
            }
        }
    }
}