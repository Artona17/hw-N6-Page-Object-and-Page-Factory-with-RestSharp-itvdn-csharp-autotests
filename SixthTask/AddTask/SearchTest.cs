namespace SixthTask
{
    /// <summary>
    /// Test written with using of Page Object pattern.
    /// </summary>
    public class SearchTest : TestBase
    {
        //Text that we search in Google for
        string searchedText = "Selenium";

        [Test]
        public void WhenSearchForTextInGoogle_ItShouldAppearOnPage()
        {
            MainPage mainPage = new MainPage(driver);
            mainPage.SearchForStringInGoogle(searchedText);
            mainPage.CheckThatPageHasNeededText(searchedText);
        }
        
    }
}