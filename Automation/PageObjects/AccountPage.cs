using System;
using AutomationFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace Tests
{
    public class AccountPage : BasePage
    {


        public AccountPage(IWebDriver _driver) : base(_driver)
        {
        }
       
        public void SignInFail()
        {
            IWebElement signInButton = waitElementIsVisibleByXpath(("//*[@id=\"header\"]/div[2]/div/div/nav/div[1]/a"));
            signInButton.Click();

            IWebElement emailInput = waitElementIsVisibleById(("email"));
            emailInput.SendKeys("Arely25a@e.co.uk");

            IWebElement passwdInput = waitElementIsVisibleById(("passwd"));
            passwdInput.SendKeys(("fail"));

            IWebElement submitLoginButton = waitElementIsVisibleById(("SubmitLogin"));
            submitLoginButton.Click();

            //Verify that a wire pruchase has been made
            IWebElement wireMsg = waitElementExistsByXpath(("//*[@id=\"center_column\"]/div[1]/ol/li"));
            Assert.IsTrue(wireMsg.Text.Contains("Invalid password."));

        }

        public void SignOut()
        {
            IWebElement signOutButton = waitElementIsVisibleByXpath(("//*[@id=\"header\"]/div[2]/div/div/nav/div[2]/a"));
            signOutButton.Click();
        }
    }
}