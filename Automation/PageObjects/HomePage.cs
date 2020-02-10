using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Interactions;
using AutomationFramework;

namespace AutomationTests
{

    public class HomePage : BasePage
    {
        public HomePage(IWebDriver _driver) : base(_driver)
        {
        }

        public void AddItemToBasket()
        {

            Actions action = new Actions(driver);
            IWebElement shortSleeveText = waitElementIsVisibleByXpath("//*[@title='Faded Short Sleeve T-shirts']");

            // hover to t shirt item
            action.MoveToElement(shortSleeveText).Build().Perform();
            IWebElement addToCartButton = waitElementIsVisibleByXpath(("//*[@data-id-product='1']"));
            addToCartButton.Click();

            IWebElement proceedToCheckoutButton = waitElementIsVisibleByXpath("//*[@title='Proceed to checkout']");
            proceedToCheckoutButton.Click();

            // add item to basket
            IWebElement proceedToCheckoutSummaryButton = waitElementIsVisibleByXpath("/html/body/div/div[2]/div/div[3]/div/p[2]/a[1]");
            proceedToCheckoutSummaryButton.Click();
        }


    }
}
