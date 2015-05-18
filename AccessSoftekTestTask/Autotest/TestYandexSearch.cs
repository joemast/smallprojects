using System.Linq;
using Framework;
using Xunit;

namespace Autotest
{
    public class TestYandexSearchAndMail : AbstractTest
    {
        /// <summary>
        /// Testcase - Test yandex search results
        /// 
        /// 1. goto yandex main page
        /// 2. make search 
        /// 3. check that results count is 10 or more and first result is expected
        /// 
        /// </summary>
        [Fact]
        public void TestSearch()
        {
            var mainPage = EnterYandexMain();
            var resultsPage = mainPage.SearchFor("Access Softek");
            var resultsList = resultsPage.GetFoundItemTitles().ToList();

            Assert.True(resultsList.Count > 9);
            Assert.Equal("Access Softek - Access Softek - Home", resultsList[0]);
        }

        /// <summary>
        /// Testcase - Test yandex mail login
        /// 
        /// 1. goto yandex main page
        /// 2. login into mail
        /// 3. check if is logged in
        /// 
        /// </summary>
        [Fact]
        public void TestMailLogin()
        {
            var mainPage = EnterYandexMain();
            var yamail = mainPage.LoginToMail("<here is your login>", "<here is your password>");

            Assert.True(yamail.IsLoggedIn());
        }
    }
}
