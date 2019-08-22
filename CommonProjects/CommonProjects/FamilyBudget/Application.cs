using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBudget
{
    class Application
    {
        private AppHelper _appHelper; 
        public Application(AppHelper appHelper)
        {
            _appHelper = appHelper;
        }
        public void Run()
        {
            while (true)
            {
                _appHelper.OpenMainPage();
                _appHelper.DetermineKeyAction();
            }
        }
    }
}