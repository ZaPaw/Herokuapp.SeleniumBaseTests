using Herokuapp.SeleniumBaseTests.Base;
using Herokuapp.SeleniumBaseTests.Pages;
using NUnit.Framework;


namespace Herokuapp.SeleniumBaseTests.Tests
{
    public class MainPageTests : Hooks
    {
        private readonly MainPage _MainPage = new MainPage();

        [Test]
        public void CanOpenMainPage()
        {
            _MainPage.OpenPage();
            Assert.IsTrue(_MainPage.IsImportantElementDisplayed(), "Main page header is not displayed.");
        }
    }
}
