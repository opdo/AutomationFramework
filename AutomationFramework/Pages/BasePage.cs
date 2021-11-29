using AutomationFramework.WebDriver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomationFramework.Pages
{
    public class BasePage
    {
        protected Browser browser;

        public BasePage(Browser browser)
        {
            this.browser = browser;
        }

        // XPath
        public By XPathSpinner = By.XPath("//div[@class = 'center']/i[contains(@class, 'fa-spin')]");

        // Method
        public void WaitSpinner(int timeout = 10)
        {
            var wait = new WebDriverWait(browser.Driver, TimeSpan.FromSeconds(timeout));
            wait.Until(drv => drv.FindElement(XPathSpinner).Displayed);
            wait.Until(drv => !drv.FindElement(XPathSpinner).Displayed);
        }
    }
}
