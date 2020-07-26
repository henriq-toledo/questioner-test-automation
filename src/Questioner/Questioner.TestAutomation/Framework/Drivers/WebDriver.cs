using System;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using Questioner.TestAutomation.Framework.Settings;

namespace Questioner.TestAutomation.Framework.Drivers
{
    public class WebDriver
    {
        public static RemoteWebDriver Driver { get; private set; }

        static WebDriver()
        {
            SetRemoveWebDriver();
        }

        private static void SetRemoveWebDriver()
        {
            switch (TestSettings.Browser)
            {
                case "firefox":
                    Driver = new FirefoxDriver();
                    break;

                default:
                    throw new Exception($"The {TestSettings.Browser} browser is not supported.");
            }
        }

        ~WebDriver()
        {
            Driver.Close();
        }
    }
}