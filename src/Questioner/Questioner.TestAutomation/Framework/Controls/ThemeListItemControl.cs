using System.ComponentModel.DataAnnotations.Schema;
using OpenQA.Selenium;
using Questioner.TestAutomation.Framework.Drivers;
using Questioner.TestAutomation.Framework.Screens;

namespace Questioner.TestAutomation.Framework.Controls
{
    public class ThemeListItemControl<TScreen>
        where TScreen : HomeScreen
    {
        [Column(Order = 0)]
        public Label<TScreen, int> Index { get; set; }
        
        [Column(Order = 1)]
        public Label<TScreen, string> Name { get; set; }
        
        [Column(Order = 2)]
        public Label<TScreen, int> Topics { get; set; }
        
        [Column(Order = 3)]
        public Label<TScreen, int> Questions { get; set; }

        public ThemeListItemControl(TScreen screen, string tableXPath)
        {
            var table = WebDriver.Driver.FindElementsByXPath(tableXPath);

            Index = Label<TScreen, int>.CreateByXPath(screen, "");
            Name = Label<TScreen, string>.CreateByXPath(screen, "");
            Topics = Label<TScreen, int>.CreateByXPath(screen, "");
            Questions = Label<TScreen, int>.CreateByXPath(screen, "");
        }

        public ThemeListItemControl()
        {
            
        }
    }
}