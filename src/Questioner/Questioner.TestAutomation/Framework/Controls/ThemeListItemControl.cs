using Questioner.TestAutomation.Framework.Screens;

namespace Questioner.TestAutomation.Framework.Controls
{
    public class ThemeListItemControl
    {
        public Label<HomeScreen, int> Index { get; set; }
        public Link<HomeScreen, string, ThemeScreen> Name { get; set; }
        public Label<HomeScreen, int> Topics { get; set; }
        public Label<HomeScreen, int> Questions { get; set; }
    }
}