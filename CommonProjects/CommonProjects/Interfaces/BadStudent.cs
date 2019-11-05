using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class BadStudent : Student
    {
        public override string Name => "BadStudent";

        public override void GoToSchool()
        {
            Console.WriteLine("Bad Student Go school");
        }
    }
}
