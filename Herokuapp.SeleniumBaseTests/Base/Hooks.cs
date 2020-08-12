using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace Herokuapp.SeleniumBaseTests.Base
{
    [TestFixture]
    public class Hooks
    {
        public static IWebDriver _WebDriver;
        private string _Driver;

        [SetUp]
        public void SetUp()
        {
            _Driver = "Edge";

            if (_Driver == "Chrome")
            {
                new DriverManager().SetUpDriver(new ChromeConfig());
                _WebDriver = new ChromeDriver();
            }
            else if (_Driver == "Firefox")
            {
                new DriverManager().SetUpDriver(new FirefoxConfig());
                _WebDriver = new FirefoxDriver();
            }

            /*   // Some problem with Edge
        else if (_Driver == "Edge")
        {
            new DriverManager().SetUpDriver(new EdgeConfig());
            _WebDriver = new EdgeDriver();
        }

            */
            else
            {
                new DriverManager().SetUpDriver(new ChromeConfig());
                _WebDriver = new ChromeDriver();

            }

            _WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            _WebDriver.Manage().Window.Maximize();
            
        }

        [TearDown]
        public void TearDown() => _WebDriver.Quit();
        
    }
}
