using OpenQA.Selenium.Chrome;

namespace SixthTask
{
    /// <summary>
    /// Test without using of Page Object pattern.
    /// </summary>
    public class NPOTests
    {
        /// <summary>
        /// Setting up a Selenium Chrome WebDriver.
        /// </summary>
        private IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://google.com");
        }

        /// <summary>
        /// Test that sets a query into Google Search and tries to get if we have needed word in search results.
        /// </summary>
        [Test]
        public void GoogleTest()
        {
            IWebElement searchBox = driver.FindElement(By.Name("q"));
            searchBox.SendKeys("Selenium");
            searchBox.SendKeys(Keys.Enter);
            IWebElement seleniumText = driver.FindElement(By.TagName("em"));
            Assert.That(seleniumText.Text == "Selenium");
        }
        /// <summary>
        /// Quitting our Chrome driver.
        /// </summary>
        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}