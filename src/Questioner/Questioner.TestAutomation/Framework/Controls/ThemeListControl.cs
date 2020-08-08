using System.Collections.Generic;
using OpenQA.Selenium;
using Questioner.TestAutomation.Framework.Actions;
using Questioner.TestAutomation.Framework.Screens;

namespace Questioner.TestAutomation.Framework.Controls
{
    public class ThemeListControl<TScreen> : BaseControl<TScreen>, IGetter<TScreen, List<ThemeListItemControl<TScreen>>>
        where TScreen : HomeScreen
    {
        protected List<ThemeListItemControl<TScreen>> Items { get; set; }

        protected ThemeListControl(TScreen screen, string identifier, IdentifierType identifierType)
            : base(screen, identifier, identifierType)
        {
            InitializeItems();
        }

        private void InitializeItems()
        {
            Items = new List<ThemeListItemControl<TScreen>>();

            var body = Control.FindElement(By.TagName("tbody"));
            var lines = body.FindElements(By.TagName("tr"));

            var lineXPath = Identifier + "/tbody/tr[{0}]/td[{1}]";

            for (int lineIndex = 1; lineIndex <= lines.Count; lineIndex++)
            {
                var model = new ThemeListItemControl<TScreen>();

                model.Index = Label<TScreen, int>.CreateByXPath(Screen, string.Format(lineXPath, lineIndex, 1));
                model.Name = Link<TScreen, string, ThemeScreen>.CreateByXPath(Screen, string.Format(lineXPath, lineIndex, 2));
                model.Topics = Label<TScreen, int>.CreateByXPath(Screen, string.Format(lineXPath, lineIndex, 3));
                model.Questions = Label<TScreen, int>.CreateByXPath(Screen, string.Format(lineXPath, lineIndex, 4));

                Items.Add(model);
            }
        }

        public static ThemeListControl<TScreen> CreateByXPath(TScreen screen, string xPath)
           => new ThemeListControl<TScreen>(screen, xPath, IdentifierType.XPath);

        public TScreen GetValue(out List<ThemeListItemControl<TScreen>> value)
        {
            value = Items;

            return Screen;
        }

        public ThemeListItemControl<TScreen> this[int index] => Items[index];
    }
}