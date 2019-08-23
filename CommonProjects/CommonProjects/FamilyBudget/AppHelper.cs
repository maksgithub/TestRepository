using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBudget
{
    class AppHelper
    {
        public void OpenAboutPage()
        {
            Console.Clear();
            FillPage(GlobalStrings.AboutPageVersion, GlobalStrings.ExitByAnyKey);
            Console.ReadKey();
        }

        public void OpenMainPage()
        {
            FillPage(GlobalStrings.MainPageHello, GlobalStrings.AboutByA,
                     GlobalStrings.ExitByE);
        }

        public void DetermineKeyAction()
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

        private void FillPage(string line1, string line2)
        {
            Console.Clear();
            Console.WriteLine(line1);
            Console.WriteLine(line2);
        }

        private void FillPage(string line1, string line2, string line3)
        {
            Console.Clear();
            Console.WriteLine(line1);
            Console.WriteLine(line2);
            Console.WriteLine(line3);
        }
    }
}
