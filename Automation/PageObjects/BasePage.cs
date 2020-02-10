
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

using System;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;
using System.Threading;
using OpenQA.Selenium.Interactions;

namespace AutomationFramework
{
    public class BasePage
    {
        public static IWebDriver driver;

        public BasePage(IWebDriver _driver)
        {
            driver = _driver;


        }
        public static IWebElement waitForTitle(String title)
        {
            (
            new WebDriverWait(driver, TimeSpan.FromSeconds(30))).Until(ExpectedConditions.TitleIs(title));
            IWebElement element = driver.FindElement(By.XPath(title));
            return element;
        }
        public static IWebElement waitElementIsVisibleByXpath(String Xpath)
        {
            (
            new WebDriverWait(driver, TimeSpan.FromSeconds(30))).Until(ExpectedConditions.ElementIsVisible(By.XPath(Xpath)));
            IWebElement element = driver.FindElement(By.XPath(Xpath));
            return element;
        }

        public static IWebElement waitElementIsClickable(String Xpath)
        {
            (
            new WebDriverWait(driver, TimeSpan.FromSeconds(30))).Until(ExpectedConditions.ElementExists(By.XPath(Xpath)));
            IWebElement element = driver.FindElement(By.XPath(Xpath));
            return element;
        }

        public static IWebElement waitElementIsVisibleById(String id)
        {
            (
            new WebDriverWait(driver, TimeSpan.FromSeconds(30))).Until(ExpectedConditions.ElementIsVisible(By.Id(id)));
            IWebElement element = driver.FindElement(By.Id(id));
            return element;

        }
        public static IWebElement waitElementIsPresentById(String id)
        {
            (
            new WebDriverWait(driver, TimeSpan.FromSeconds(30))).Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.Id(id)));
            IWebElement element = driver.FindElement(By.Id(id));
            return element;
        }
        public static IWebElement waitElementExistsByXpath(String Xpath)
        {
            (
            new WebDriverWait(driver, TimeSpan.FromSeconds(30))).Until(ExpectedConditions.ElementExists(By.XPath(Xpath)));
            IWebElement element = driver.FindElement(By.XPath(Xpath)); ;
            return element;
        }
    }



}