using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Framework
{
    /// <summary>
    /// Test context object
    /// 
    /// Contains context for current test. WebDriver instance, Wait object for explicit waiting, etc.
    /// 
    /// </summary>
    public class TestContext
    {
        private static TestContext _instance;
        public IWebDriver Driver { get; private set; }
        public WebDriverWait Wait { get; private set; }

        /// <summary>
        /// Context creation means new WebDriver instance is created (new browser window)
        /// </summary>
        private TestContext()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();

            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(2));
        }

        static public TestContext Instance()
        {
            return _instance ?? (_instance = new TestContext());
        }

        static public void ClearInstance()
        {
            _instance = null;
        }
    }
}
