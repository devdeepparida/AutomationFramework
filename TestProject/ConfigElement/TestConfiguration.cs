using System.Configuration;

namespace AutoFramework.ConfigElement
{
    public class TestConfiguration: ConfigurationSection
    {
        private static TestConfiguration _testConfig = (TestConfiguration)ConfigurationManager.GetSection("TestConfiguration");

        public static TestConfiguration AutoSettings => _testConfig;

        [ConfigurationProperty("testSettings")]
        public FrameworkElementCollection TestSettings => (FrameworkElementCollection)base["testSettings"];
    }
}
