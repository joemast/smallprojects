using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Xunit.Sdk;

namespace Framework.Pages
{
    /// <summary>
    /// Yandex main page
    /// 
    /// The page shown by http://yandex.ru 
    /// 
    /// </summary>
    public class YandexMainPage : BasePage
    {
        [FindsBy (How = How.CssSelector, Using = "#text")]
        private IWebElement SearchField;
        [FindsBy(How = How.XPath, Using = "//td[contains(@class, 'search__button')]/button")]
        private IWebElement SeachButton;
        [FindsBy(How = How.XPath, Using = "//form//div[@class = 'auth__username']//input")]
        private IWebElement MailLoginField;
        [FindsBy(How = How.XPath, Using = "//form//div[@class = 'auth__password']//input")]
        private IWebElement MailPasswordField;
        [FindsBy(How = How.XPath, Using = "//form//div[@class = 'auth__button']//button")]
        private IWebElement MailSubmitButton;

        public YandexMainPage(TestContext context) : base(context)
        {
        }

        public YandexSearchResultsPage SearchFor(string queryText)
        {
            SearchField.Clear();
            SearchField.SendKeys(queryText);
            SeachButton.Click();

            return new YandexSearchResultsPage(Context);
        }

        public YandexMailMainPage LoginToMail(string login, string password)
        {
            MailLoginField.SendKeys(login);
            MailPasswordField.SendKeys(password);
            MailSubmitButton.Click();
            return new YandexMailMainPage(Context);
        }
    }
}
