using System;
using System.IO;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSeleniumC_training.Selenium
{
    internal class FileDownload
    {
        IWebDriver driver;
        string downloadPath = "C:\\Users\\achba\\Documents\\Selenium\\PracticeImages";

        [SetUp]
        public void StartBrowser()
        {
            // Configure the web driver manager to set up the Chrome capabilities
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());

            // Initialize the web driver
            driver = new ChromeDriver();

            // Launch the Firefox browser
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/download");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Testcase1()
        {
            // Find the file link and click to download
            IWebElement fileLink = driver.FindElement(By.LinkText("image.png"));
            fileLink.Click();

            // Wait for the file to be downloaded
            Thread.Sleep(5000);


        }

        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}