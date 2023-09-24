using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using NUnit;

namespace Selenium {

    [TestFixture] 
    public class BrowserState
    {
        public ChromeDriver driver;
        
        [SetUp]  
        public void Setup() 
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5000);
            // Add explicit timeout in here
            driver.Navigate().GoToUrl("https://youtube.com");
        }

        [TearDown] 
        public void Teardown() 
        {
            Thread.Sleep(5);
            driver.Quit();
        }   

    }
}