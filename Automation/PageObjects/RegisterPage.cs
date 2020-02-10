using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AutomationFramework.PageObjects
{
    public class RegisterPage : BasePage
    {


        public RegisterPage(IWebDriver _driver) : base(_driver)
        {
        }

        public void RegisterAccount()
        {

            IWebElement SubmitCreateButton = waitElementIsVisibleById("SubmitCreate");

            // user used for registration
            var user = User.GetSampleTableData();

            IWebElement proceedToCheckoutButton = waitElementIsVisibleById(("email_create"));
            proceedToCheckoutButton.SendKeys((string)user[300].EmailAddress);

            IWebElement CreateAnAccountButton = waitElementIsVisibleById(("SubmitCreate"));
            CreateAnAccountButton.Click();

            IWebElement customerFirstnameInput = waitElementIsVisibleById(("customer_firstname"));
            customerFirstnameInput.SendKeys((string)user[300].FirstName);


            IWebElement customerLastnameInput = waitElementIsVisibleById(("customer_lastname"));
            customerLastnameInput.SendKeys((string)user[300].LastName);

            IWebElement emailInput = waitElementIsVisibleById(("email"));


            IWebElement passwordInput = waitElementIsVisibleById(("passwd"));
            passwordInput.SendKeys("aaaaaa££££££££££4444444444");


            IWebElement addressInput = waitElementIsVisibleById(("address1"));
            addressInput.SendKeys((string)user[300].Street);


            IWebElement addcityinput = waitElementIsVisibleById(("city"));
            addcityinput.SendKeys((string)user[300].City);

            IWebElement addpostCodeInput = waitElementIsVisibleById(("postcode"));
            addpostCodeInput.SendKeys("00000");


            IWebElement mobileInput = waitElementIsVisibleById(("phone_mobile"));
            mobileInput.SendKeys("00000000000000000");

            IWebElement stateDrop = waitElementIsPresentById(("id_state"));
            SelectElement stateSelect = new SelectElement(stateDrop);
            stateSelect.SelectByValue("19");

            // Register an account button
            IWebElement submitAccountButton = waitElementIsVisibleById(("submitAccount"));
            submitAccountButton.Click();


            IWebElement proAddButton = waitElementIsVisibleByXpath(("//*[@name='processAddress']"));
            proAddButton.Click();

            IWebElement proShipButton = waitElementIsPresentById(("cgv"));
            proShipButton.Click();


            IWebElement processCarrierButton = waitElementIsVisibleByXpath(("//*[@name='processCarrier']"));
            processCarrierButton.Click();

            IWebElement wireButton = waitElementIsVisibleByXpath(("//*[@title='Pay by bank wire']"));
            wireButton.Click();

            IWebElement wireButtons = waitElementIsVisibleByXpath(("//*[@id='cart_navigation']/button"));
            wireButtons.Click();


            //Verify that a wire pruchase has been made
            IWebElement wireMsg = waitElementExistsByXpath(("//*[@id=\"center_column\"]/div/p/strong"));
            Assert.IsTrue(wireMsg.Text == "Your order on My Store is complete.");

        }
    }
}
