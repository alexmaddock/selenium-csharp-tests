using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using NUnit;

namespace Selenium {

    [TestFixture] 
    public class SeleniumTest : BrowserState
    {

        [Test]
        public void VisitPage() 
        {
            var homePageTitle = driver.Title;
            StringAssert.Contains("YouTube", homePageTitle);

            var searchBox = driver.FindElement(By.XPath("//input[@id='search']"));
            searchBox.Click();
            searchBox.SendKeys("9 Top Automated Testing Practices to Follow.");
            var searchIcon = driver.FindElement(By.Id("search-icon-legacy"));
            searchIcon.Click();

            Thread.Sleep(5000);
            var titles = driver.FindElements(By.Id("video-title"));//.GetAttribute("innerText");
            foreach(IWebElement title in titles) {
                // Console.WriteLine(title.Text);
                if(title.Text.Contains("9 Top Automated Testing Practices to Follow."))
                    Console.WriteLine("Found title, selecting" + " " + title.Text);
                    // Console.WriteLine("ELEMENT IS: ", title);
                    title.Click();
    
            }
            
            // Console.WriteLine(titleFind);
            // StringAssert.Contains(titleFind, "9 Top Automated Testing Practices to Follow.");
            // var textBox = driver.FindElementBy("originInput-input");
            // Assert.IsNotEmpty(textBox.GetAttribute("textContent"));
            // Assert.IsNotEmpty(textBox.GetAttribute("value"));
            
    
        }

    }
}