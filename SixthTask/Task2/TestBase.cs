using OpenQA.Selenium.Chrome;

namespace SixthTask.Task2
{
    public class TestBase
    {
        /// <summary>
        /// Setting up a Selenium Chrome WebDriver.
        /// </summary>
        public IWebDriver driver;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl("https://demo.litecart.net/");
        }

        /// <summary>
        /// Quitting our Chrome driver.
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
