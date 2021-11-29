using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace AutomationFramework.Pages
{
    public class ResultPage : BasePage
    {
        public ResultPage(IWebDriver driver) : base(driver)
        {
        }

        // Element
        public By XPathCef = By.XPath("//div[@class = 'card event-item']");
        public List<IWebElement> ListCef => driver.FindElements(XPathCef).ToList();

        // Method
        public int GetTotalRecords()
        {
            return ListCef.Count;
        }
    }
}
