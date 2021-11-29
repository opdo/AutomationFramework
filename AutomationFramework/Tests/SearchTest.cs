using AutomationFramework.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AutomationFramework.Tests
{
    public class SearchTest
    {
        public IWebDriver Driver;
        readonly SearchPage searchPage;

        public SearchTest()
        {
            Driver = new ChromeDriver();
            searchPage = new SearchPage(Driver);
        }

        [Fact]
        public void SearchCorrectStudentCode()
        {
            Driver.Url = "https://hutechcheckin.com/";
            searchPage.SearchByStudentCode("1611060042");
        }
    }
}
