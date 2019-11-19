using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCast
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog("Tusik");
            Dog dog2 = new Dog("Amur");

            Bird b1 = new Bird("Gorobec");
            Bird b2 = new Bird("Sinichka");

            dog1.Run();
            dog2.Run();

            b1.Fly();
            b2.Fly();

            Console.ReadLine();
        }
    }
}
