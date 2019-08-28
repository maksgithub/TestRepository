using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairCostCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo k;
            while (true)
            {
                Console.WriteLine("Press E for exit\nPress A for about\nPress U to create user");
                k = Console.ReadKey();
                if (k.Key == ConsoleKey.E)
                {
                    break;
                }
                if (k.Key == ConsoleKey.A)
                {
                    Console.Clear();
                    Console.WriteLine("Project RepairCostCalculator version 1.0.0.0\nPress any key to return ...");
                    Console.ReadKey();
                }
                if (k.Key == ConsoleKey.U)
                {
                    Console.Clear();
                    Console.WriteLine("Write user name and press Enter key");
                    
                    User();
                    Console.ReadLine();
                }
                Console.Clear();
            }

        }
        private static void User()
        {
            string name;
            name = Console.ReadLine();
            if (CheckString(name) == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Only characters are allowed");
            }
            int lname = name.Length;
            if (lname < 3 & lname > 15)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Name must be longer than 3 characters and less than 15 characters");
            }



        }
        static bool CheckString(string name)
        {
            for (int i = 0; i < name.Length; ++i)
            {
                if (char.IsLetter(name[i]))
                {
                    return true;
                }
            }

            return false;
        }







    }
}