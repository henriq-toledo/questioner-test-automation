using Questioner.TestAutomation.Framework.Screens;

namespace Questioner.TestAutomation.Framework.Controls
{
    public class ResultTopicListItemControl
    {
        public Label<ResultScreen, int> Index { get; set; }
        public Label<ResultScreen, string> Topic { get; set; }
        public Label<ResultScreen, int> Percentage { get; set; }
        public Label<ResultScreen, string> Result { get; set; }
    }
}