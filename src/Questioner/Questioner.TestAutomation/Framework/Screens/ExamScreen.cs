using Questioner.TestAutomation.Framework.Controls;

namespace Questioner.TestAutomation.Framework.Screens
{
    public class ExamScreen : BaseScreen
    {
        public Label<ExamScreen, string> ThemeName { get; set; }
        public Button<ExamScreen, ResultScreen> FinishButton { get; set; }
        public TopicListControl<ThemeScreen> Topics { get; set; }
        public TopicListControl<ThemeScreen> Questions { get; set; }

        public ExamScreen()
        {
            ThemeName = Label<ExamScreen, string>.CreateByXPath(this, "/html/body/div/main/form/div[1]/h3");
            FinishButton = Button<ExamScreen, ResultScreen>.CreateByXPath(this, "/html/body/div/main/form/div[10]/input");
        }
    }
}