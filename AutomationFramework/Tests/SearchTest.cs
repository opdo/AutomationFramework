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
            searchPage = new SearchPage(Driver);
            resultPage = new ResultPage(Driver);
        }

        [Fact]
        public void SearchCorrectStudentCode()
        {
            searchPage.SearchByStudentCode("1611060042");
            int totalRecords = resultPage.GetTotalRecords();
            Assert.True(totalRecords > 0);
        }

        [Fact]
        public void SearchWrongStudentCode()
        {
            searchPage.SearchByStudentCode("1111111111");
        }
    }
}
