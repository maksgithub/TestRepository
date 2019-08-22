using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBudget
{
    class Program
    {
        static void Main(string[] args)
        {
            AppHelper helper = new AppHelper();
            Application app = new Application(helper);
            app.Run();
        }
    }
}
