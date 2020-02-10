using AutomationTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using AutomationFramework.PageObjects;

namespace Tests
{
    [TestClass]
    public class HomePageTests
    {
        public static IWebDriver driver;


        [TestInitialize]
        public void Setup()
        {

            driver = new ChromeDriver(".");
            driver.Navigate().GoToUrl("http://automationpractice.com/");
            driver.Manage().Window.Maximize();

        }

        [TestMethod]
        public void PurchaseItemAsNewUser()
        {

            HomePage homePage = new HomePage(driver);
            homePage.AddItemToBasket();


            RegisterPage registerPage = new RegisterPage(driver);
            registerPage.RegisterAccount();

            AccountPage accountPage = new AccountPage(driver);
            accountPage.SignOut();
        }
        // test that a valid email and an invalid password fails
        [TestMethod]
        public void NegSignInFails()
        {

            AccountPage accountPage = new AccountPage(driver);
            accountPage.SignInFail();
        }



        [TestCleanup]
        public void TearDown()
        {

            driver.Quit();

        }

    }

}
