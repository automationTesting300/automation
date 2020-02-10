using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;


using System;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;
using System.Threading;
using OpenQA.Selenium.Interactions;
using AutomationTests;
using OpenQA.Selenium.Chrome;

namespace Tests
{
    public class BaseTests
    {
        public static IWebDriver driver;
        //driver

        [TestInitialize]
        public void Setup()
        {
            // Runs before each test. (Optional)

            if (driver == null)
            {
                driver = new ChromeDriver(".");
                driver.Navigate().GoToUrl("http://automationpractice.com/");
                driver.Manage().Window.Maximize();
            }


        }
        [TestCleanup]
        public void TearDown()
        {

        }
    }
}