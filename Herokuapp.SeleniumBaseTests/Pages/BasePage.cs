using Herokuapp.SeleniumBaseTests.Base;
using OpenQA.Selenium;


namespace Herokuapp.SeleniumBaseTests.Pages
{
    public abstract class BasePage
    {
        private readonly string _BaseUrl = "https://the-internet.herokuapp.com/";
        public static IWebDriver WebDriver => Hooks._WebDriver;
        public string PartialUrl { get; private set; }
        public By ImportantElement { get; private set; }

        public BasePage(string partialUrl, By impotantElement)
        {
            this.PartialUrl = partialUrl;
            this.ImportantElement = impotantElement;
        }


        public void OpenPage()
        {
            GoToPage();
            // WaitForPage();
        }

        public void GoToPage() => WebDriver.Navigate().GoToUrl(_BaseUrl + PartialUrl);

        public bool IsImportantElementDisplayed() => WebDriver.FindElement(ImportantElement).Displayed;

    }
}
