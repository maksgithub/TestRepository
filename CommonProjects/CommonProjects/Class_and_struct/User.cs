using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_and_struct
{

    struct User
    {
        public User(int age, string name, string passwrod)
        {
            Age = age;
            Name = name;
            Password = passwrod;
        }

        public string Name;
        public int Age;
        public string Password;

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}  Age: {Age}  Password: {Password}");
        }
    }
}

