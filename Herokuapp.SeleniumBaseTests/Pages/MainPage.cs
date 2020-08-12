using OpenQA.Selenium;

namespace Herokuapp.SeleniumBaseTests.Pages
{
    public class MainPage : BasePage
    {
        private static readonly By _Header = By.XPath("//h1[text()='Welcome to the-internet']");

        public MainPage() : base("", _Header)
        {
        }
     
    }
}
