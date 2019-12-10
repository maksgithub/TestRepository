using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Events3
{
    class LoopRunner
    {
        public event Action LoopEntered;

        public void Run()
        {

            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(500);
                LoopEntered?.Invoke();
            }
        }
    }
}
