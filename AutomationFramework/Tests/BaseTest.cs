using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace AutomationFramework.Tests
{
    public class BaseTest : IDisposable
    {
        public IWebDriver Driver;

        public BaseTest()
        {
            Driver = new ChromeDriver();
            Driver.Url = "https://hutechcheckin.com/";
        }

        public void Dispose()
        {
            if (Driver != null)
            {
                Driver.Close();
                Driver.Dispose();
            }
        }
    }
}
