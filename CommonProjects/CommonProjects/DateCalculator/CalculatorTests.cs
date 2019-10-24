using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DateCalculator
{
    [TestFixture]
    class CalculatorTests
    {

        [Test]
        public void TestCalculation()
        {
            int a = 5;
            int b = 6;

            var res = Calculator.Calculate(a, b);

            Assert.AreEqual(res, 11);
        }
    }
}
