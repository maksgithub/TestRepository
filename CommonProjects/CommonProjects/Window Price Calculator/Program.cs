﻿using System;
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
            RunApplication();
        }

        private static void RunApplication()
        {
            while (true)
            {
                PrintMainMenu();
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.E)
                {
                    break;
                }
                if (keyInfo.Key == ConsoleKey.A)
                {
                    PrintAboutMenu();
                }
                if (keyInfo.Key == ConsoleKey.U)
                {
                    Username();
                }
            }
        }

        private static void PrintAboutMenu()
        {
            Console.Clear();
            Console.WriteLine("Windows Price calcuator version 1.1");
            Console.WriteLine("Press any key to return...");
            Console.ReadKey();
        }

        static void PrintMainMenu()
        {
            Console.Clear();
            Console.WriteLine("Press E for exit");
            Console.WriteLine("Press A for about");
            Console.WriteLine("Press U to create user");
        }
        private static void Username()
        {
            Console.Clear();
            Console.WriteLine("Write user name and press Enter key");
            string name = Console.ReadLine();

        }
    }
}

