namespace Questioner.TestAutomation.Framework.Actions
{
    public interface IGetter<TScreen, TType>
    {
         TScreen GetValue(out TType value);
    }
}