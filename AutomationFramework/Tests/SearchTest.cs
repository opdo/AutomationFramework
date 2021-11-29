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
            Driver.Url = "https://hutechcheckin.com/";
            searchPage.SearchByStudentCode("1611060042");
        }

        [Fact]
        public void SearchWrongStudentCode()
        {
            Driver.Url = "https://hutechcheckin.com/";
            searchPage.SearchByStudentCode("1111111111");
        }
    }
}
