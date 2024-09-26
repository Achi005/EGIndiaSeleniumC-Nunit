using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumC_Training.NUNITTests
{
   // [Allure.NUnit.AllureNUnit]
    internal class AllureReportGen
    {
        [Test , Order(0)]
        public void login()
        {
            Console.WriteLine("logged in");
        }
    }
}
