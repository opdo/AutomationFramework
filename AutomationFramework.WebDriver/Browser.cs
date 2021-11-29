using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AutomationFramework.WebDriver
{
    public class Browser
    {
        public IWebDriver Driver;

        public Browser(BrowserType type = BrowserType.Chrome)
        {
            Driver = BrowserFactory.GetWebDriver(type);
        }

        public Browser(string type = "Chrome")
        {
            Enum.TryParse(type, out BrowserType browserType);
            Driver = BrowserFactory.GetWebDriver(browserType);
        }

        // Method base on driver
        public void Go(string url)
        {
            Driver.Url = url;
        }

        public IWebElement GetElement(By xpath)
        {
            return Driver.FindElement(xpath);
        }

        public List<IWebElement> GetElements(By xpath)
        {
            return Driver.FindElements(xpath).ToList();
        }

        public IWebElement GetElement(string xpath)
        {
            return GetElement(By.XPath(xpath));
        }

        public List<IWebElement> GetElements(string xpath)
        {
            return GetElements(By.XPath(xpath)).ToList();
        }

        public void Close()
        {
            Driver.Close();
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
