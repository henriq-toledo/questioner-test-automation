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
                .Themes.GetValue(out var themes)
                .Themes[0].Name.Click()
                .Topics.GetValue(out var topics)
                .StartButton.Click();

            // Assert
            Assert.Equal(expected: 2, actual: themes.Count);
            Assert.Equal(expected: 4, actual: topics.Count);

            // var item = list.FirstOrDefault();
            // item.Index.GetValue(out var index);
            // item.Name.GetValue(out var name);
            // item.Topics.GetValue(out var topics);
            // item.Questions.GetValue(out var questions);
        }
    }
}