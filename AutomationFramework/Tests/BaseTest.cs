using AutomationFramework.Services;
using AutomationFramework.WebDriver;
using System;

namespace AutomationFramework.Tests
{
    public class BaseTest : IDisposable
    {
        public Browser Browser;

        public BaseTest()
        {
            Browser = new Browser(ConfigService.GetValue("browser"));
            Browser.Go(ConfigService.GetValue("url"));
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
