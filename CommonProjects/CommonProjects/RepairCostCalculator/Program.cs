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
                Console.Clear();
                switch (k.Key)
                {
                    case ConsoleKey.E:
                        {
                            Environment.Exit(0);
                            break;
                        }
                    case ConsoleKey.A:
                        {                            
                            Console.WriteLine("Project RepairCostCalculator version 1.0.0.0\nPress any key to return ...");                            
                            break;
                        }
                    case ConsoleKey.U:
                        {                            
                            Console.WriteLine("Write user name and press Enter key");
                            CreateUser();
                            
                            break;
                        }                         
                }
                Console.ReadKey();
                Console.Clear();
            }

             User CreateUser()
            {
                string name;
                name = Console.ReadLine();
                bool isNotLetter = !IsContainsOnlyLetters(name);
                if (isNotLetter)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nOnly characters are allowed");
                }

                int lname = name.Length;
                bool isNotLength = (lname < 3 || lname > 15);
                if (isNotLength)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nName must be longer than 3 characters and less than 15 characters");
                }


                Console.ForegroundColor = ConsoleColor.White;
                if (!isNotLength & !isNotLetter)
                {
                    Console.WriteLine("User created");
                    return new User();
                }
                else
                {
                    Console.WriteLine("User not created");
                    return null;
                }

            }
            bool IsContainsOnlyLetters(string name)
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
}