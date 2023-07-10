using OpenQA.Selenium.Support.UI;

namespace SixthTask.Task2
{
    //Methods and locators used for work with the page of the duck
    public class DuckPage
    {
        public IWebDriver Driver;
        //Locators
        private By greenDuck = By.XPath("//section[@id='box-popular-products']//a[@title='Green Duck']");
        private By addToCart = By.CssSelector(".btn.btn-success");
        private By acceptCookies = By.Name("accept_cookies");
        private By cartQuantity = By.CssSelector(".badge.quantity");
        private By cartIcon = By.XPath("//a[@id='cart']");

        public DuckPage(IWebDriver driver)
        {
            Driver = driver;
        }

        /// <summary>
        /// Getting on the page of the chosen duck, adding it into the cart and going to the cart page
        /// </summary>
        public void AddGreenDuckToCart()
        {
            Driver.FindElement(acceptCookies).Click();
            Driver.FindElement(greenDuck).Click();

            Driver.FindElement(addToCart).Click();

            //waiting for the animation of adding product to the cart to pass
            new WebDriverWait(Driver, TimeSpan.FromSeconds(5)).Until(c => Driver.FindElement(cartQuantity).Displayed);
            Driver.FindElement(cartIcon).Click();
        }

    }

}
