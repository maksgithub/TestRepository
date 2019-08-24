using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Window_Price_Calculator
{
    class UserCreate
    {
        static void Main(string[] args)
        {
            Username();
        }
        private static void Username()
        {
            Console.Clear();
            Console.WriteLine("Write user name and press Enter key");
            string name = Console.ReadLine();
        }
    }
}
