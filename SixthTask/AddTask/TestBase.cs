using OpenQA.Selenium.Chrome;

namespace SixthTask
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
            driver.Navigate().GoToUrl("https://google.com");
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
