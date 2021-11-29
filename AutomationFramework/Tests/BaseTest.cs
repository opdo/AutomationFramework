using AutomationFramework.WebDriver;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace AutomationFramework.Tests
{
    public class BaseTest : IDisposable
    {
        public Browser Browser;

        public BaseTest()
        {
            Browser = new Browser();
            Browser.Go("https://hutechcheckin.com/");
        }

        public void Dispose()
        {
            if (Browser != null)
            {
                Browser.Close();
            }
        }
    }
}
