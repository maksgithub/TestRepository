using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empty
{
    // public class Order
    // internal class Order - by default
    class Order
    {
        // consts
        public const int Coeficient = 2;
        internal const string Title3 = "Title3" + Title2;
        protected const string Title2 = "Title2";
        private const string Title = "Title1" + Title2;
        const string Title4 = "Title4" + Title2;

        public int _number = 5;
        internal int _number2 = 5;
        protected int _number3 = 5;
        private int _number4 = 5;
        int _number5 = 5;

        public static int Count2 { get; set; }

        private int _count;
        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                _count = value;
            }
        }

        public void Print()
        {
            Console.WriteLine(Count);
        }

        public void Print(string text)
        {
            Console.WriteLine(text);
        }

        int Calculate()
        {
            return Coeficient * _number;
        }

        public Order()
        {
            
        }
    }
}
