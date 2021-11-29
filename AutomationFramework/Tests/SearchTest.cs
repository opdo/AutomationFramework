using AutomationFramework.Pages;
using Xunit;

namespace AutomationFramework.Tests
{
    public class SearchTest : BaseTest
    {
        readonly SearchPage searchPage;
        readonly ResultPage resultPage;

        public SearchTest()
        {
            searchPage = new SearchPage(Browser);
            resultPage = new ResultPage(Browser);
        }

        /// <summary>
        /// Test student have more than 1 cerf
        /// </summary>
        [Fact]
        public void SearchCorrectStudentCode()
        {
            searchPage.SearchByStudentCode("1611060042");
            searchPage.WaitSpinner();
            int totalRecords = resultPage.GetTotalRecords();
            Assert.True(totalRecords > 0);
        }

        /// <summary>
        /// Test wrong student code
        /// </summary>
        [Fact]
        public void SearchWrongStudentCode()
        {
            searchPage.SearchByStudentCode("1111111111");
        }
    }
}
