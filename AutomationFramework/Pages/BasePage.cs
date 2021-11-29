using OpenQA.Selenium;

namespace AutomationFramework.Pages
{
    public class BasePage
    {
        protected IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void WaitSpinner()
        {

        }
    }
}
