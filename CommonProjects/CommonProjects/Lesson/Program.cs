using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Slon slon1 = new Slon();
            slon1.Rost = 59;

            slon1.PrintAll();           

            Console.ReadLine();
            
        }
       
    }
}
