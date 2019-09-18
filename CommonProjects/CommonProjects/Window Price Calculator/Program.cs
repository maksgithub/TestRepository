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
                    CreateUser();
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

        private static void CreateUser()
        {
            Console.Clear();
            Console.WriteLine("Write user name and press Enter key");
            string name = Console.ReadLine();
            bool isLenhthValid = LengthCheck(name);
            if (isLenhthValid)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Name must be longer than 3 characters and less than 15 characters");
            }
            Console.ForegroundColor = ConsoleColor.White;
            bool isOnlyLetters = !IsContainsOnlyLetters(name);
            if (isOnlyLetters)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Only characters are allowed");

            }
            if (!isOnlyLetters & !isLenhthValid)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("User created");
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }

        private static bool LengthCheck(string name)
        {
            int n = name.Length;
            bool lenth = n < 3 || n > 15;
            return lenth;

        }
        static bool IsContainsOnlyLetters(string name)
        {
            for (int i = 0; i < name.Length; ++i)
            {
                char c = name[i];
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}


