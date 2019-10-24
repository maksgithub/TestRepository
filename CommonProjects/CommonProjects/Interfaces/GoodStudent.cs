using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class GoodStudent : IStudent
    {
        public GoodStudent(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public void GoToSchool()
        {
            Console.WriteLine(Name + " Good Go to school");
        }

        public int GetMark()
        {
            return 5;
        }
    }
}
