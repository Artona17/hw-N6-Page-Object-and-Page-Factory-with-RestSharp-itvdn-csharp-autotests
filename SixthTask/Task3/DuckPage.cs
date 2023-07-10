using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace SixthTask.Task3
{
    //Methods and locators used for work with the page of the duck
    public class DuckPage
    {
        public IWebDriver Driver;

        //Locators
        [FindsBy(How = How.Name, Using = "accept_cookies")]
        public IWebElement acceptCookies { get; set; }

        [FindsBy (How = How.XPath, Using = "//section[@id='box-popular-products']//a[@title='Green Duck']")]
        public IWebElement greenDuck { get; set; }

        [FindsBy (How = How.CssSelector, Using = ".btn.btn-success")]
        public IWebElement addToCart { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".badge.quantity")]
        public IWebElement cartQuantity { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='cart']")]
        public IWebElement cartIcon { get; set; }

        public DuckPage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(driver, this);
        }

        /// <summary>
        /// Getting on the page of the chosen duck, adding it into the cart and going to the cart page
        /// </summary>
        public DuckPage AddGreenDuckToCart()
        {
            acceptCookies.Click();
            greenDuck.Click();

            addToCart.Click();

            //waiting for the animation of adding product to the cart to pass
            new WebDriverWait(Driver, TimeSpan.FromSeconds(5)).Until(c => cartQuantity.Displayed);
            cartIcon.Click();
            return new DuckPage(Driver);
        }

    }

}
