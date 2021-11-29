using AutomationFramework.WebDriver;
using OpenQA.Selenium;

namespace AutomationFramework.Pages
{
    public class SearchPage : BasePage
    {

        public SearchPage(Browser browser) : base(browser)
        {
        }

        // Element
        public IWebElement InputSearch => browser.GetElement("//input[@data-bind = 'textInput: studentID']");
        public IWebElement ButtonSearch => browser.GetElement("//button[@id = 'btnSearch']");

        // Method
        public void SearchByStudentCode(string code)
        {
            InputSearch.SendKeys(code);
            ButtonSearch.Click();
        }
    }
}
