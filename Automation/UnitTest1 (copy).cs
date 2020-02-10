using AutomationTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Automation
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {IWebDriver driver = new FirefoxDriver();
            HomePage homePage = new HomePage(driver,"hey");
            homePage.AddItemToBasket("hi");
        }
    }
}
