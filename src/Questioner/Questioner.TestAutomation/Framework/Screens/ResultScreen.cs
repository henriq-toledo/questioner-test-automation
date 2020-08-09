using Questioner.TestAutomation.Framework.Controls;

namespace Questioner.TestAutomation.Framework.Screens
{
    public class ResultScreen : BaseScreen
    {
        public Label<ResultScreen, string> ThemeName { get; set; }
        public Label<ResultScreen, string> Percentage { get; set; }
        public Button<ResultScreen, ResultScreen> ExportToExcelButton { get; set; }
        public ResultTopicListControl Topics { get; set; }
        public ResultQuestionListControl Questions { get; set; }

        public ResultScreen()
        {
            ThemeName = Label<ResultScreen, string>.CreateByXPath(this, "/html/body/div/main/form/div[1]/div[1]/h3");
            Percentage = Label<ResultScreen, string>.CreateByXPath(this, "/html/body/div/main/form/div[1]/div[2]/h5");
            ExportToExcelButton = Button<ResultScreen, ResultScreen>.CreateByXPath(this, "/html/body/div/main/form/div[4]/input");
            Topics = ResultTopicListControl.CreateByXPath(this, "/html/body/div/main/form/div[2]/table");
            Questions = ResultQuestionListControl.CreateByXPath(this, "/html/body/div/main/form/div[3]/table");
        }
    }
}