using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace FirstProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Name("q")).SendKeys("c# with selenium");
            driver.FindElement(By.XPath("(//input[@type='submit'])[3]")).Click();
            driver.Close();
        }
    }
}
