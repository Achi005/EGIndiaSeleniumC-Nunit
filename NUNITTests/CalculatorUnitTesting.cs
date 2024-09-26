using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumC_Training.NUNITTests
{
    internal class CalculatorUnitTesting
    {
        
        Calculator cl = new Calculator();

        [Test]
        public void AddTest()
        {
            int result = cl.Add(2, 3);

            int result1 = cl.Add(3, -4);

            Assert.AreEqual(5, result);

            Assert.AreEqual(-1, result1);
        }
    }
}
