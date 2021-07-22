using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FirstProject1
{
    [TestFixture]
    class Nunit
    {
        IWebDriver driver;

        [SetUp]
        public void Intilize()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.Manage().Window.Maximize();


        }

        [Test]
        public void SearchTest()
        {
            driver.FindElement(By.Name("q")).SendKeys("c# with selenium");
            driver.FindElement(By.XPath("(//input[@type='submit'])[3]")).Click();
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }

    }
}
