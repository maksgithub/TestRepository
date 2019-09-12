using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_2
{
    class Person
    {
        public Person(string name)
        {
            Name = name;
            new User(name);
        }

        public int Age { get; set; }
        public string Name { get; set; }
        public int SecondName { get; set; }
        public void SetName()
        {
            Name = "Vano";
        }

        public void Run(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(Name + " Is running");
            }
        }
    }

    internal class User
    {
        public User(string name)
        {
            Console.WriteLine(name);
        }
    }
}
