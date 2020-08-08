using Questioner.TestAutomation.Framework.Screens;

namespace Questioner.TestAutomation.Framework.Controls
{
    public class ThemeListItemControl<TScreen>
        where TScreen : HomeScreen
    {
        public Label<TScreen, int> Index { get; set; }
        public Link<TScreen, string, ThemeScreen> Name { get; set; }
        public Label<TScreen, int> Topics { get; set; }
        public Label<TScreen, int> Questions { get; set; }
    }
}