using Questioner.TestAutomation.Framework.Controls;

namespace Questioner.TestAutomation.Framework.Screens
{
    public class ThemeScreen : BaseScreen
    {
        public Label<ThemeScreen, string> ThemeName { get; set; }
        public Button<ThemeScreen, ExamScreen> StartButton { get; set; }
        public TopicListControl<ThemeScreen> Topics { get; set; }

        public ThemeScreen()
        {
            ThemeName = Label<ThemeScreen, string>.CreateByXPath(this, "/html/body/div/main/div[1]/h3");
            Topics = TopicListControl<ThemeScreen>.CreateByXPath(this, "/html/body/div/main/table");
            StartButton = Button<ThemeScreen, ExamScreen>.CreateByXPath(this, "/html/body/div/main/div[2]/a");
        }
    }
}