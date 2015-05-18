using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Framework.Pages
{
    /// <summary>
    /// Yandex Mail main page
    /// 
    /// The page right after login
    /// 
    /// </summary>
    public class YandexMailMainPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//a[contains(@class, 'b-link_current')]")]
        private IWebElement mailLink;

        public YandexMailMainPage(TestContext context) : base(context)
        {
        }

        public bool IsLoggedIn()
        {
            return "Почта".Equals(mailLink.Text);
        }
    }
}
