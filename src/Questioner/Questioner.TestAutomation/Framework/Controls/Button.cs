using Questioner.TestAutomation.Framework.Screens;

namespace Questioner.TestAutomation.Framework.Controls
{
    public class Button<TScreen, TLinkedScreen> : BaseControl<TScreen>
        where TLinkedScreen : BaseScreen, new()
    {
        protected Button(TScreen screen, string identifier, IdentifierType identifierType) 
            : base(screen, identifier, identifierType)
        {
        }

        public TLinkedScreen Click()
        {
            Control.Click();

            return new TLinkedScreen();
        }

        public static Button<TScreen, TLinkedScreen> CreateByXPath(TScreen screen, string xPath)
            => new Button<TScreen, TLinkedScreen>(screen, xPath, IdentifierType.XPath);
    }
}