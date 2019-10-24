using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class BadStudent : IStudent
    {

        public BadStudent(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public void GoToSchool()
        {
            Console.WriteLine(Name + " Bad Go to school");
        }

        public int GetMark()
        {
            return 1;
        }
    }
}
