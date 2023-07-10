using SeleniumExtras.PageObjects;

namespace SixthTask.Task3
{
    //Methods and locators used for work with main page
    public class MainPage
    {
        public IWebDriver Driver;

        //Locators
        [FindsBy (How = How.CssSelector, Using = ".alert.alert-success")]
        public IWebElement alert { get; set; }

        [FindsBy (How = How.LinkText, Using = "Sign In")]
        public IWebElement signInBtn { get; set; }

        [FindsBy (How = How.Name, Using = "email")]
        public IWebElement email { get; set; }

        [FindsBy (How = How.Name, Using = "password")]
        public IWebElement password { get; set; }

        [FindsBy (How = How.Name, Using = "login")]
        public IWebElement loginBtn { get; set; }

        public MainPage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(driver, this);
        }

        /// <summary>
        /// Method that checks that we logged in succesfully if we found particular <param name="text">message</param>
        /// on page
        /// </summary>
        public void CheckThatAlertMsgContainsText(string text)
        {
            Assert.That(alert.Text.Contains(text));
        }

        /// <summary>
        /// Logging in with <param name="em">email</param> and <param name="pwd">password</param>
        /// </summary>
        public MainPage LoginWithEmailAndPassword(string em, string pwd)
        {
            signInBtn.Click();

            email.Clear();
            email.SendKeys(em);

            password.Clear();
            password.SendKeys(pwd);
            loginBtn.Click();

            return new MainPage(Driver);
        }

    }

}
