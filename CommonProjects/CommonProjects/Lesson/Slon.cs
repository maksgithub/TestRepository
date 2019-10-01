using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    class Slon
    {
        public int Wes { get; }
        public int Rost { private get; set; }
        private string Name { get; set; }

        private const int countLegs = 4;
        public const string father = "Dimon";
        public string _chastTela;
        private int _vozrast;

        public  Slon()
        {
           
        }
        
         public void PrintAll()
        {
            Console.WriteLine(Name+" "+Calculate());


        }
         public int Calculate()
        {
            return Wes * Wes;
        }
    }
}
