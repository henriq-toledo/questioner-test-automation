using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Questioner.TestAutomation.Framework.Settings
{
    public class TestSettings
    {
        public static string WebAppUrl { get; private set; }
        public static string Browser { get; private set; }

        static TestSettings()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName)
                .AddJsonFile("appsettings.json", false)
                .Build();

            var testSettings = configuration.GetSection(nameof(TestSettings));

            WebAppUrl = testSettings[nameof(WebAppUrl)];
            Browser = testSettings[nameof(Browser)];
        }
    }
}