using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;

namespace Framework.Pages
{
    /// <summary>
    /// Base page abstract class
    /// 
    /// Inits page elements.
    /// Contains Test Context object for use in pages. 
    /// 
    /// </summary>
    public class BasePage
    {
        protected TestContext Context { get; set; }

        public BasePage(TestContext context)
        {
            Context = context;
            PageFactory.InitElements(Context.Driver, this);
        }
    }
}
