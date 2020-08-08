using System.Linq;
using Questioner.TestAutomation.Framework.Screens;
using Xunit;

namespace Questioner.TestAutomation.Tests
{
    public class HomeTests
    {
        [Fact]
        public void Test1()
        {
            // Arrange

            // Act
            HomeScreen
                .Go()
                .Themes.GetValue(out var list)
                .Themes[0].Name.Click();

            // Assert
            Assert.Equal(expected: 2, actual: list.Count);

            // var item = list.FirstOrDefault();
            // item.Index.GetValue(out var index);
            // item.Name.GetValue(out var name);
            // item.Topics.GetValue(out var topics);
            // item.Questions.GetValue(out var questions);
        }
    }
}