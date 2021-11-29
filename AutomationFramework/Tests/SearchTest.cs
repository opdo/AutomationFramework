using AutomationFramework.Pages;
using Xunit;

namespace AutomationFramework.Tests
{
    public class SearchTest : BaseTest
    {
        readonly SearchPage searchPage;

        public SearchTest()
        {
            searchPage = new SearchPage(Driver);
        }

        [Fact]
        public void SearchCorrectStudentCode()
        {
            searchPage.SearchByStudentCode("1611060042");
        }

        [Fact]
        public void SearchWrongStudentCode()
        {
            searchPage.SearchByStudentCode("1111111111");
        }
    }
}
