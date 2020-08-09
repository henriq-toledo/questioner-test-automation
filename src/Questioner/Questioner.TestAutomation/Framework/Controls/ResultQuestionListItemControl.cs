using Questioner.TestAutomation.Framework.Screens;

namespace Questioner.TestAutomation.Framework.Controls
{
    public class ResultQuestionListItemControl
    {
        public Label<ResultScreen, int> Index { get; set; }
        public Label<ResultScreen, string> Question { get; set; }        
        public Label<ResultScreen, string> Correct { get; set; }
    }
}