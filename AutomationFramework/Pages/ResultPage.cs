using AutomationFramework.WebDriver;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace AutomationFramework.Pages
{
    public class ResultPage : BasePage
    {
        public ResultPage(Browser browser) : base(browser)
        {
        }

        // Element
        public By XPathCef = By.XPath("//div[@class = 'card event-item']");
        public List<IWebElement> ListCef => browser.GetElements(XPathCef);

        // Method
        public int GetTotalRecords()
        {
            return ListCef.Count;
        }
    }
}
