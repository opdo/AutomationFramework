using OpenQA.Selenium;

namespace AutomationFramework.Pages
{
    public class SearchPage : BasePage
    {

        public SearchPage(IWebDriver driver) : base(driver)
        {
        }

        // Element
        public IWebElement InputSearch => driver.FindElement(By.XPath("//input[@data-bind = 'textInput: studentID']"));
        public IWebElement ButtonSearch => driver.FindElement(By.XPath("//button[@id = 'btnSearch']"));

        // Method
        public void SearchByStudentCode(string code)
        {
            InputSearch.SendKeys(code);
            ButtonSearch.Click();
        }
    }
}
