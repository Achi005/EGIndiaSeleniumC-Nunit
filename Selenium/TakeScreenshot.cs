using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Support.Extensions;

namespace NUnitSeleniumC_Training.Selenium
{
    internal class TakeScreenshot
    {
        IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            // confifgure the web driver manager to set up the chrome capabilities
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            // intialize the web driver 
            driver = new ChromeDriver();
            // launch the forefox browser

            driver.Navigate().GoToUrl("https://www.selenium.dev/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void testcase1()
        {
            // take screen shot class and gets screenshot as method
            Screenshot ss = driver.TakeScreenshot();
            ss.SaveAsFile("C:\\Users\\achba\\Documents\\Selenium\\PracticeImages\\image.jpg");
        }   


        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }
    }
}
