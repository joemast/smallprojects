using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Framework.Pages
{
    /// <summary>
    /// Yandex Search results page
    /// 
    /// The page where search results appear
    /// 
    /// </summary>
    public class YandexSearchResultsPage : BasePage
    {
        private readonly By _foundItem = By.XPath("//div[@class = 'serp-list']//a[@class = 'b-link serp-item__title-link']");

        public YandexSearchResultsPage(TestContext context) : base(context)
        {
        }

        public IEnumerable<string> GetFoundItemTitles()
        {
            Context.Wait.Until(d => d.FindElement(_foundItem));
            var elements = Context.Driver.FindElements(_foundItem);
            var result = elements.ToList().ConvertAll(el => el.Text);
            return result;
        }

    }
}
