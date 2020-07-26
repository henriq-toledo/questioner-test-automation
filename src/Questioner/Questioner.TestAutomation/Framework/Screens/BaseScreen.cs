using Questioner.TestAutomation.Framework.Drivers;

namespace Questioner.TestAutomation.Framework.Screens
{
    public abstract class BaseScreen
    {
        public BaseScreen(string url)
            => WebDriver.Driver.Navigate().GoToUrl(url);
    }
}