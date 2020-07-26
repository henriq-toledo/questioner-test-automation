using Questioner.TestAutomation.Framework.Drivers;
using Questioner.TestAutomation.Framework.Settings;
using Xunit;

namespace Questioner.TestAutomation
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            WebDriver.Driver.Navigate().GoToUrl(TestSettings.WebAppUrl);
        }
    }
}
