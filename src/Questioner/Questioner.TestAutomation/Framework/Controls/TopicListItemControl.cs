using Questioner.TestAutomation.Framework.Screens;

namespace Questioner.TestAutomation.Framework.Controls
{
    public class TopicListItemControl
    {
        public Label<ThemeScreen, int> Index { get; set; }
        public Label<ThemeScreen, string> Name { get; set; }
        public Label<ThemeScreen, int> Percentage { get; set; }
        public Label<ThemeScreen, int> Questions { get; set; }
    }
}