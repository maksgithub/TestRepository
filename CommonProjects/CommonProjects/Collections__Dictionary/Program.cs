using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections__Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> dict2 = new Dictionary<string, List<int>>();
            dict2.Add("Ivan", new List<int>() { 11, 12, 10 });

            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "Max");
            dict.Add(0, "Mars");
            dict.Add(38467, "Vano");

            string name1 = dict[1];
            Console.WriteLine(name1);

            string name2;
            bool isExist = dict.TryGetValue(45, out name2);
            Console.WriteLine(name2);

            string name3;
            bool isExist2 = dict.TryGetValue(0, out name3);
            Console.WriteLine(name2);

            dict.TryGetValue(456, out _);
            Console.WriteLine(name2);

            Console.ReadLine();
        }
    }
}
