using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBudget
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (true)
            {
                Console.Clear();
                OpenMainPage();
                i++;
                DetermineKeyAction();
            }
        }

        private static void DetermineKeyAction()
        {
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.E:
                    Environment.Exit(0);
                    break;
                case ConsoleKey.A:
                    OpenAboutPage();
                    break;
            }
        }

        private static void OpenMainPage()
        {
            Console.WriteLine("Hello in Family Budget program!");
            Console.WriteLine("Press A for about");
            Console.WriteLine("Press E for exit");
        } 

        private static void OpenAboutPage()
        {
            Console.Clear();
            Console.WriteLine("Project Name version 1.0.0.0");
            Console.WriteLine("Press any key to return ...");
            Console.ReadKey();
        }
    }
}
