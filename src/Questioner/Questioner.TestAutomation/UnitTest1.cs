using System;
using Questioner.TestAutomation.Framework.Classes.Settings;
using Xunit;

namespace Questioner.TestAutomation
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var a = TestSettings.WebAppUrl;
        }
    }
}
