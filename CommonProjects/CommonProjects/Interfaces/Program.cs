using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            
           //Student studen1 = new BadStudent();
            Student studen2 = new GoodStudent();

            //studen1.GoToSchool();
            studen2.GoToSchool();

            Console.Read();
        }
    }
}
