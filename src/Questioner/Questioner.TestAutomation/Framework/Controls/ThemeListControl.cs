using System.Collections.Generic;
using OpenQA.Selenium;
using Questioner.TestAutomation.Framework.Actions;
using Questioner.TestAutomation.Framework.Screens;

namespace Questioner.TestAutomation.Framework.Controls
{
    public class ThemeListControl : BaseControl<HomeScreen>, IGetter<HomeScreen, List<ThemeListItemControl>>
    {
        protected List<ThemeListItemControl> Items { get; set; }

        protected ThemeListControl(HomeScreen screen, string identifier, IdentifierType identifierType)
            : base(screen, identifier, identifierType)
        {
            InitializeItems();
        }

        private void InitializeItems()
        {
            Items = new List<ThemeListItemControl>();

            var body = Control.FindElement(By.TagName("tbody"));
            var lines = body.FindElements(By.TagName("tr"));

            var lineXPath = Identifier + "/tbody/tr[{0}]/td[{1}]";

            for (int lineIndex = 1; lineIndex <= lines.Count; lineIndex++)
            {
                var model = new ThemeListItemControl();

                model.Index = Label<HomeScreen, int>.CreateByXPath(Screen, string.Format(lineXPath, lineIndex, 1));
                model.Name = Link<HomeScreen, string, ThemeScreen>.CreateByXPath(Screen, string.Format(lineXPath, lineIndex, 2));
                model.Topics = Label<HomeScreen, int>.CreateByXPath(Screen, string.Format(lineXPath, lineIndex, 3));
                model.Questions = Label<HomeScreen, int>.CreateByXPath(Screen, string.Format(lineXPath, lineIndex, 4));

                Items.Add(model);
            }
        }

        public static ThemeListControl CreateByXPath(HomeScreen screen, string xPath)
           => new ThemeListControl(screen, xPath, IdentifierType.XPath);

        public HomeScreen GetValue(out List<ThemeListItemControl> value)
        {
            value = Items;

            return Screen;
        }

        public ThemeListItemControl this[int index] => Items[index];
    }
}