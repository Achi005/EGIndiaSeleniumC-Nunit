using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumC_Training.NUNITTests
{
    internal class Assertions
    {
        [Test]
        public void Testassertions()
        {
            String actual = "google";
            string expected = "yahoo";

          /*  if (actual == expected)
            {
                Console.WriteLine("the results are matching");
            }
            else
            {
                Console.WriteLine("not matching");
            }
          */

            //assert equal
            Assert.AreEqual(actual, expected);

            Assert.AreNotEqual(actual, expected);

            Assert.AreSame(actual, expected);   

            Assert.AreNotSame(actual, expected);

            //assert that
            Assert.That(actual, Is.EqualTo(expected));

            Assert.That(actual,Is.Not.EqualTo(expected));

            //assert for strings ignore case
            Assert.That(actual , Is.EqualTo(expected).IgnoreCase);

            // substring presense
            Assert.That(actual, Does.Contain("def").IgnoreCase);

            Assert.That(actual, Does.Not.Contain("def").IgnoreCase);

            // empty assertions
            Assert.IsEmpty(actual);

            Assert.That(actual,Is.Empty);

            // custom assetion

            int age = 17;
            if (age <= 8)
            {

            }

            

        }
    }
}
