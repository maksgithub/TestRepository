using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> list = new List<int>();
                list.Add(42);
                list.Add(23);


                var di = new DirectoryInfo(@"C:\Users\MARS\source\repos1");

                if(di.Exists)
                {
                    var f = di.EnumerateFiles();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
