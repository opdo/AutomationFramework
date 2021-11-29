using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomationFramework.Pages
{
    public class BasePage
    {
        protected IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        // XPath
        public By XPathSpinner = By.XPath("//div[@class = 'center']/i[contains(@class, 'fa-spin')]");

        // Method
        public void WaitSpinner(int timeout = 10)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
            wait.Until(drv => drv.FindElement(XPathSpinner).Displayed);
            wait.Until(drv => !drv.FindElement(XPathSpinner).Displayed);
        }
    }
}
