using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_and_struct
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            string p = Console.ReadLine();
            User tom = new User(34, n, p);
            ModifyName(tom);
            tom.DisplayInfo();
            Console.ReadKey();
        }
        static void ModifyName(User user)
        {
            user.Name = "Ivan";
        }
    }
}
