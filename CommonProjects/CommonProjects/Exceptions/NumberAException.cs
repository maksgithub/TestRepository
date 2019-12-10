using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class NumberAException : Exception
    {
        public NumberAException(string message)
            : base(message)
        {
        }
    }
}
