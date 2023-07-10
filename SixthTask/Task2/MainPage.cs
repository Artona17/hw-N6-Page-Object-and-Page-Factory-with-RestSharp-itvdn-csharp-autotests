namespace SixthTask.Task2
{
    //Methods and locators used for work with main page
    public class MainPage
    {
        public IWebDriver Driver;

        //Locators
        private By alert = By.CssSelector(".alert.alert-success");
        private By signInBtn = By.LinkText("Sign In");
        private By email = By.Name("email");
        private By password = By.Name("password");
        private By loginBtn = By.Name("login");

        public MainPage(IWebDriver driver)
        {
            Driver = driver;
        }

        /// <summary>
        /// Method that checks that we logged in succesfully if we found particular <param name="text">message</param>
        /// on page
        /// </summary>
        public void CheckThatAlertMsgContainsText(string text)
        {
            Assert.That(Driver.FindElement(alert).Text.Contains(text));
        }

        /// <summary>
        /// Logging in with <param name="em">email</param> and <param name="pwd">password</param>
        /// </summary>
        public void LoginWithEmailAndPassword(string em, string pwd)
        {
            Driver.FindElement(signInBtn).Click();

            Driver.FindElement(email).Clear();
            Driver.FindElement(email).SendKeys(em);

            Driver.FindElement(password).Clear();
            Driver.FindElement(password).SendKeys(pwd);
            Driver.FindElement(loginBtn).Click();
        }

    }

}
