using System.Configuration;

namespace AutomationFramework.Services
{
    public static class ConfigService
    {
        public static string GetValue(string key)
        {
            if (ConfigurationManager.AppSettings[key] is null)
            {
                return null;
            }

            return ConfigurationManager.AppSettings[key].ToString();
        }
    }
}
