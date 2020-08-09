using Questioner.TestAutomation.Framework.Controls;
using Questioner.TestAutomation.Framework.Settings;

namespace Questioner.TestAutomation.Framework.Screens
{
    public class HomeScreen : BaseScreen
    {
        public ThemeListControl Themes { get; private set; }

        private HomeScreen()
        : base(TestSettings.WebAppUrl)
        {
            Themes = ThemeListControl.CreateByXPath(this, "/html/body/div/main/table");
        }

        public static HomeScreen Go() => new HomeScreen();
    }
}