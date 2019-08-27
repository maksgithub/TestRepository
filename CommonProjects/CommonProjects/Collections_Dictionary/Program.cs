using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> hashSet = new HashSet<int>();
            hashSet.Add(1);
            hashSet.Add(1);
            hashSet.Add(1);
            hashSet.Add(1);
            bool isAdded = hashSet.Add(1);
            bool contains = hashSet.Contains(1);

            Console.WriteLine(contains);
            Console.WriteLine(hashSet.Count);

            Console.ReadLine();
        }
    }
}
