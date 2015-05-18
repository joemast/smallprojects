using System;
using Framework.Pages;

namespace Framework
{
    /// <summary>
    /// 
    /// Abstract test parent class
    /// Implements common test logic for setup and teardown every test
    /// 
    /// </summary>
    public abstract class AbstractTest : IDisposable
    {
        private TestContext Context { get; set; }

        /// <summary>
        /// Context is created for every test [Fact]
        /// </summary>
        protected AbstractTest()
        {
            Context = TestContext.Instance();
        }

        protected YandexMainPage EnterYandexMain()
        {
            Context.Driver.Navigate().GoToUrl("http://yandex.ru");

            return new YandexMainPage(Context);
        }

        /// <summary>
        /// After test [Fact] finished with any result it is necessary to clear context and close the browser
        /// </summary>
        public void Dispose()
        {
            Context.Driver.Quit();
            TestContext.ClearInstance();
        }
    }
}
