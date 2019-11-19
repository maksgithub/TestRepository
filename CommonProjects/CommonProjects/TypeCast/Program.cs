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
            var animals = new List<IAnimal>();

            animals.Add((IAnimal)new Dog("Tusik"));
            animals.Add((IAnimal)new Dog("Amur"));
            animals.Add((IAnimal)new Bird("Gorobec"));
            animals.Add((IAnimal)new Bird("Sinichka"));

            foreach (IAnimal animal in animals)
            {
                var dog = animal as Dog;
                if (dog != null)
                {
                    dog.Run();
                }
            }

            Console.ReadLine();
        }

        private static void NewMethod1()
        {
            var dog1 = new Dog("Tusik");
            IAnimal dog2 = new Dog("Amur");

            var b1 = new Bird("Gorobec");
            IAnimal b2 = new Bird("Sinichka");

            dog1.Run();
            var dog3 = (Dog) dog2;
            dog3.Run();

            b1.Fly();

            var b3 = b2 as Dog;
            var b4 = (Dog) b2;
        }
    }
}
