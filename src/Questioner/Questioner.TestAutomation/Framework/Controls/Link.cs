using OpenQA.Selenium;
using Questioner.TestAutomation.Framework.Screens;

namespace Questioner.TestAutomation.Framework.Controls
{
    public class Link<TScreen, TType, TLinkedScreen> : Label<TScreen, TType>
        where TScreen : BaseScreen
        where TLinkedScreen : BaseScreen, new()
    {
        protected Link(TScreen screen, string identifier, IdentifierType identifierType)
            : base(screen, identifier, identifierType)
        {
        }

        public TLinkedScreen Click()
        {
            Control.FindElement(By.TagName("a")).Click();

            return new TLinkedScreen();
        }

        new public static Link<TScreen, TType, TLinkedScreen> CreateByXPath(TScreen screen, string xPath)
            => new Link<TScreen, TType, TLinkedScreen>(screen, xPath, IdentifierType.XPath);
    }
}