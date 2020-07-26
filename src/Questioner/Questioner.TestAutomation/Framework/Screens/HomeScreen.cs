using Questioner.TestAutomation.Framework.Settings;

namespace Questioner.TestAutomation.Framework.Screens
{
    public class HomeScreen : BaseScreen
    {
        private HomeScreen()
        : base(TestSettings.WebAppUrl)
        {
        }

        public static HomeScreen Go() => new HomeScreen();
    }
}