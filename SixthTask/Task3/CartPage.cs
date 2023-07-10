using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace SixthTask.Task3
{
    //Methods and locators used for work with the cart page
    public class CartPage
    {
        public IWebDriver Driver;

        //Locators
        [FindsBy (How = How.Name, Using = "terms_agreed")]
        public IWebElement checkboxForOrder { get; set; }

        [FindsBy (How = How.Name, Using = "confirm_order")]
        public IWebElement orderConfirmation { get; set; }

        [FindsBy (How = How.CssSelector, Using = ".card-title")]
        public IWebElement successfulOrderText { get; set; }

        public CartPage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(driver, this);
        }

        /// <summary>
        /// Checking if we have <param name="result">the text</param> for successful order in the page that loaded after our order
        /// </summary>
        public void CheckThatOrderWasCompletedSuccessfully(string result)
        {
            Assert.That(successfulOrderText.Text.Contains(result));
        }

        /// <summary>
        /// Confirming our order
        /// </summary>
        public CartPage ConfirmOrder()
        {
            checkboxForOrder.Click();
            orderConfirmation.Click();
            return new CartPage(Driver);
        }
    }
}
