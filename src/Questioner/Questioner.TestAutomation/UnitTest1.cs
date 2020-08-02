using System.Linq;
using Questioner.TestAutomation.Framework.Screens;
using Xunit;

namespace Questioner.TestAutomation
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            HomeScreen
                .Go()
                .Themes.GetValue(out var list);

            Assert.Equal(expected: 2, actual: list.Count);

            var item = list.FirstOrDefault();
            item.Index.GetValue(out var index);
            item.Name.GetValue(out var name);
            item.Topics.GetValue(out var topics);
            item.Questions.GetValue(out var questions);

            var a = 0;
        }
    }
}
