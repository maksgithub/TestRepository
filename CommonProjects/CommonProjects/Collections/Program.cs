using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>(200);
            List<int> list2 = new List<int>();
            List<bool> list3 = new List<bool>();
            List<ConsoleKeyInfo> list4 = new List<ConsoleKeyInfo>();

            list.Add("bla_bla_1");
            list.Add("2");

            list.AddRange(new[] {"3", "4"});
            bool isExist = list.Contains("4");
            list.Remove("bla_bla_1");

            int index = list.IndexOf("3");
            Console.WriteLine($"index = {index}");

            Console.WriteLine(list[2]);

            Console.ReadLine();
        }
    }
}
