using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Fffff";
            var i = a.GetCount('f');
            Console.WriteLine(i);

            var l = new List<int>(10000000);
            l.Add(1);
            l.Add(1);
            l.Add(1);
            l.Add(1);
            l.Add(1);
            l.Add(56);
            l.Add(1);
            l.Add(1);
            l.Add(1);
            l.Add(1);
            l.Add(1);
            l.Add(1);
            l.Add(1);
            l.Add(1);
            l.Add(1);
            l.Add(1);
            l.Add(1);
            Console.WriteLine(l[5]);
            Console.ReadLine();
        }
    }
}
