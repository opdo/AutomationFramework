using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Pages
{
    public class SearchPage
    {
        private IWebDriver driver;

        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
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
