using System;
using OpenQA.Selenium.Firefox;
using Questioner.TestAutomation.Framework.Classes.Settings;
using Xunit;

namespace Questioner.TestAutomation
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            using(var webDriver = new FirefoxDriver())
            {                
                webDriver.Navigate().GoToUrl(TestSettings.WebAppUrl);
            }
        }
    }
}
