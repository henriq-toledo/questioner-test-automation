using System.Collections.Generic;
using OpenQA.Selenium;
using Questioner.TestAutomation.Framework.Actions;
using Questioner.TestAutomation.Framework.Screens;

namespace Questioner.TestAutomation.Framework.Controls
{
    public class ResultQuestionListControl : BaseControl<ResultScreen>, IGetter<ResultScreen, List<ResultQuestionListItemControl>>        
    {
        protected List<ResultQuestionListItemControl> Items { get; set; }

        protected ResultQuestionListControl(ResultScreen screen, string identifier, IdentifierType identifierType)
            : base(screen, identifier, identifierType)
        {
            InitializeItems();
        }

        private void InitializeItems()
        {
            Items = new List<ResultQuestionListItemControl>();

            var body = Control.FindElement(By.TagName("tbody"));
            var lines = body.FindElements(By.TagName("tr"));

            var lineXPath = Identifier + "/tbody/tr[{0}]/td[{1}]";

            for (int lineIndex = 1; lineIndex <= lines.Count; lineIndex++)
            {
                var model = new ResultQuestionListItemControl();

                model.Index = Label<ResultScreen, int>.CreateByXPath(Screen, string.Format(lineXPath, lineIndex, 1));
                model.Question = Label<ResultScreen, string>.CreateByXPath(Screen, string.Format(lineXPath, lineIndex, 2));
                model.Correct = Label<ResultScreen, string>.CreateByXPath(Screen, string.Format(lineXPath, lineIndex, 3));                

                Items.Add(model);
            }
        }

        public static ResultQuestionListControl CreateByXPath(ResultScreen screen, string xPath)
           => new ResultQuestionListControl(screen, xPath, IdentifierType.XPath);

        public ResultScreen GetValue(out List<ResultQuestionListItemControl> value)
        {
            value = Items;

            return Screen;
        }

        public ResultQuestionListItemControl this[int index] => Items[index];
    }
}