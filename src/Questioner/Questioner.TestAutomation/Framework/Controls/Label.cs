using System;
using Questioner.TestAutomation.Framework.Actions;

namespace Questioner.TestAutomation.Framework.Controls
{
    public class Label<TScreen, TType> : BaseControl<TScreen>, IGetter<TScreen, TType>
    {
        protected Label(TScreen screen, string identifier, IdentifierType identifierType)
            : base(screen, identifier, identifierType)
        {
        }

        public TScreen GetValue(out TType value)
        {
            value = (TType)Convert.ChangeType(Control.Text, typeof(TType));

            return Screen;
        }

        public static Label<TScreen, TType> CreateById(TScreen screen, string id)
            => new Label<TScreen, TType>(screen, id, IdentifierType.Id);

        public static Label<TScreen, TType> CreateByXPath(TScreen screen, string xPath)
            => new Label<TScreen, TType>(screen, xPath, IdentifierType.XPath);
    }
}