using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationFramework.WebDriver
{
    public class Browser
    {
        public IWebDriver Driver;

        public Browser(BrowserType type = BrowserType.Chrome)
        {
            Driver = BrowserFactory.GetWebDriver(type);
        }
    }

    public class BrowserFactory
    {
        public static IWebDriver GetWebDriver(BrowserType type = BrowserType.Chrome)
        {
            // Init IWebDriver
            IWebDriver webDriver = null;

            switch (type)
            {
                case BrowserType.Chrome:
                    webDriver = new ChromeDriver();
                    webDriver.Manage().Window.Maximize();
                    break;
            }

            return webDriver;
        }
    }
}
