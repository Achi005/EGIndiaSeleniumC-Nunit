using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumC_Training.NUNITTests
{
   // [Allure.NUnit.AllureNUnit]
    [Parallelizable(ParallelScope.All)]
    internal class ParallelExecution
    {

        [Test]
        public void login()
        {
            Console.WriteLine("logged in again");
        }

        [Test]
        public void product()
        {
            Console.WriteLine("product open");
        }
    }
}
