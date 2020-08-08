using System.Collections.Generic;
using OpenQA.Selenium;
using Questioner.TestAutomation.Framework.Actions;
using Questioner.TestAutomation.Framework.Screens;

namespace Questioner.TestAutomation.Framework.Controls
{
    public class TopicListControl<TScreen> : BaseControl<TScreen>, IGetter<TScreen, List<TopicListItemControl>>
        where TScreen : ThemeScreen
    {
        protected List<TopicListItemControl> Items { get; set; }

        protected TopicListControl(TScreen screen, string identifier, IdentifierType identifierType)
            : base(screen, identifier, identifierType)
        {
            InitializeItems();
        }

        private void InitializeItems()
        {
            Items = new List<TopicListItemControl>();

            var body = Control.FindElement(By.TagName("tbody"));
            var lines = body.FindElements(By.TagName("tr"));

            var lineXPath = Identifier + "/tbody/tr[{0}]/td[{1}]";

            for (int lineIndex = 1; lineIndex <= lines.Count; lineIndex++)
            {
                var model = new TopicListItemControl();

                model.Index = Label<ThemeScreen, int>.CreateByXPath(Screen, string.Format(lineXPath, lineIndex, 1));
                model.Name = Label<ThemeScreen, string>.CreateByXPath(Screen, string.Format(lineXPath, lineIndex, 2));
                model.Percentage = Label<ThemeScreen, int>.CreateByXPath(Screen, string.Format(lineXPath, lineIndex, 3));
                model.Questions = Label<ThemeScreen, int>.CreateByXPath(Screen, string.Format(lineXPath, lineIndex, 4));

                Items.Add(model);
            }
        }

        public static TopicListControl<TScreen> CreateByXPath(TScreen screen, string xPath)
           => new TopicListControl<TScreen>(screen, xPath, IdentifierType.XPath);

        public TScreen GetValue(out List<TopicListItemControl> value)
        {
            value = Items;

            return Screen;
        }

        public TopicListItemControl this[int index] => Items[index];
    }
}