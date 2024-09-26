using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumC_Training.NUNITTests
{
    internal class CategoryTesting
    {

        [Test, Order(1)]
        public void Login()
        {
            Console.WriteLine("Logging into apllication");
        }

        [Test, Order(2)]
        public void Product()
        {
            Console.WriteLine();
        }

        [Test, Order(3)]
        public void AddToCart()
        {

        }

    }
}
