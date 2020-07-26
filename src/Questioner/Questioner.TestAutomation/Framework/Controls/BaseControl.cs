using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using Questioner.TestAutomation.Framework.Drivers;

namespace Questioner.TestAutomation.Framework.Controls
{
    public class BaseControl<TScreen>
    {
        protected RemoteWebDriver Driver {get;private set;}
        protected TScreen Screen { get; private set; }
        protected string Identifier { get; private set; }
        protected IdentifierType IdentifierType { get; private set; }
        protected IWebElement Control => IdentifierType switch
        {
            IdentifierType.Id => Driver.FindElementById(Identifier),
            IdentifierType.XPath => Driver.FindElementByXPath(Identifier),
            _ => throw new Exception($"{IdentifierType} identifier type not supported.")
        };

        public BaseControl(TScreen screen, string identifier, IdentifierType identifierType)
        {
            Screen = screen;
            Identifier = identifier;
            IdentifierType = identifierType;

            Driver = WebDriver.Driver;
        }
    }
}