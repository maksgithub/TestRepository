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

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Press E for exit");
                Console.WriteLine("Press A for about");
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.E)
                {
                    break;
                }
                if (keyInfo.Key == ConsoleKey.A)
                {
                    Console.Clear();
                    Console.WriteLine("Project name version 1.0");
                    Console.WriteLine("Press any key to return...");
                    Console.ReadKey();
                }

            }
        }
    }
}