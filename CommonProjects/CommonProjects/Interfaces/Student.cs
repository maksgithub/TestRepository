using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public abstract class Student
    {
        public virtual string Name => "Student";

        public virtual void GoToSchool()
        {
            Console.WriteLine("Student Go school");
        }
    }
}
