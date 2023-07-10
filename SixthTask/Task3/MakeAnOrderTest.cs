using OpenQA.Selenium.Chrome;

namespace SixthTask.Task3
{
    /// <summary>
    /// Test written with using of Page Factory pattern.
    /// </summary>
    internal class MakeAnOrderTest : TestBase
    {
        [Test]
        public void MakeAnOrderTest_OrderMadeSuccessfully()
        {
            MainPage mainPage = new MainPage(driver);
            DuckPage duckPage = new DuckPage(driver);
            CartPage cartPage = new CartPage(driver);

            //main page
            mainPage.LoginWithEmailAndPassword("user@email.com", "demo");
            mainPage.CheckThatAlertMsgContainsText("logged in as John Doe");

            //duck page
            duckPage.AddGreenDuckToCart();

            //cart page
            cartPage.ConfirmOrder();
            cartPage.CheckThatOrderWasCompletedSuccessfully("was completed successfully");
        }
    }
}
