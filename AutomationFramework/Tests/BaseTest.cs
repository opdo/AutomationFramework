using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationFramework.Tests
{
    public class BaseTest
    {
        public IWebDriver Driver;

        public BaseTest()
        {
            Driver = new ChromeDriver();
            Driver.Url = "https://hutechcheckin.com/";
        }
    }
}
