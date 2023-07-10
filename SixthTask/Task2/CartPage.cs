using OpenQA.Selenium.Support.UI;

namespace SixthTask.Task2
{
    //Methods and locators used for work with the cart page
    public class CartPage
    {
        public IWebDriver Driver;
        //Locators
        private By checkboxForOrder = By.Name("terms_agreed");
        private By orderConfirmation = By.Name("confirm_order");
        private By successfulOrderText = By.CssSelector(".card-title");

        public CartPage(IWebDriver driver)
        {
            Driver = driver;
        }

        /// <summary>
        /// Checking if we have <param name="result">the text</param> for successful order in the page that loaded after our order
        /// </summary>
        public void CheckThatOrderWasCompletedSuccessfully(string result)
        {
            Assert.That(Driver.FindElement(successfulOrderText).Text.Contains(result));
        }

        /// <summary>
        /// Confirming our order
        /// </summary>
        public void ConfirmOrder()
        {
            Driver.FindElement(checkboxForOrder).Click();
            Driver.FindElement(orderConfirmation).Click();
        }
    }
}
