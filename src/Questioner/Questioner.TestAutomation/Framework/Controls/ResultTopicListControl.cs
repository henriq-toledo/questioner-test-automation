using System.Collections.Generic;
using OpenQA.Selenium;
using Questioner.TestAutomation.Framework.Actions;
using Questioner.TestAutomation.Framework.Screens;

namespace Questioner.TestAutomation.Framework.Controls
{
    public class ResultTopicListControl : BaseControl<ResultScreen>, IGetter<ResultScreen, List<ResultTopicListItemControl>>        
    {
        protected List<ResultTopicListItemControl> Items { get; set; }

        protected ResultTopicListControl(ResultScreen screen, string identifier, IdentifierType identifierType)
            : base(screen, identifier, identifierType)
        {
            InitializeItems();
        }

        private void InitializeItems()
        {
            Items = new List<ResultTopicListItemControl>();

            var body = Control.FindElement(By.TagName("tbody"));
            var lines = body.FindElements(By.TagName("tr"));

            var lineXPath = Identifier + "/tbody/tr[{0}]/td[{1}]";

            for (int lineIndex = 1; lineIndex <= lines.Count; lineIndex++)
            {
                var model = new ResultTopicListItemControl();

                model.Index = Label<ResultScreen, int>.CreateByXPath(Screen, string.Format(lineXPath, lineIndex, 1));
                model.Topic = Label<ResultScreen, string>.CreateByXPath(Screen, string.Format(lineXPath, lineIndex, 2));
                model.Percentage = Label<ResultScreen, int>.CreateByXPath(Screen, string.Format(lineXPath, lineIndex, 3));
                model.Result = Label<ResultScreen, string>.CreateByXPath(Screen, string.Format(lineXPath, lineIndex, 4));

                Items.Add(model);
            }
        }

        public static ResultTopicListControl CreateByXPath(ResultScreen screen, string xPath)
           => new ResultTopicListControl(screen, xPath, IdentifierType.XPath);

        public ResultScreen GetValue(out List<ResultTopicListItemControl> value)
        {
            value = Items;

            return Screen;
        }

        public ResultTopicListItemControl this[int index] => Items[index];
    }
}