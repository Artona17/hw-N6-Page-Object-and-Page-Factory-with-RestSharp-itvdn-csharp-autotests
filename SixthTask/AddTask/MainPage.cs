namespace SixthTask
{
    //Methods and locators used for work with main page
    public class MainPage
    {
        public IWebDriver Driver;

        //Locators
        private By searchBar = By.Name("q");
        private By searchString = By.TagName("em");

        public MainPage(IWebDriver driver)
        {
            Driver = driver;
        }

        /// <summary>
        /// Checking that we have needed <param name="text">text</param> among the search results
        /// </summary>
        public void CheckThatPageHasNeededText(string text)
        {
            Assert.That(Driver.FindElement(searchString).Text.Contains(text));
        }

        /// <summary>
        /// Typing our <param name="text">string</param> into the searchbar
        /// </summary>
        public void SearchForStringInGoogle(string text)
        {
            Driver.FindElement(searchBar).SendKeys(text);
            Driver.FindElement(searchBar).SendKeys(Keys.Enter);
            Driver.FindElement(searchString);
        }

    }

}
