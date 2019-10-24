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
            
            IStudent studen1 = new BadStudent("123");
            IStudent studen2 = new GoodStudent("345");

            Console.WriteLine(studen1.GetMark());

            studen2.GoToSchool();
            Console.WriteLine(studen2.GetMark());

            Console.Read();
        }
    }
}
