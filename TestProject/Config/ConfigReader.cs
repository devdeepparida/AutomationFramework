using System;
using AutoFramework.Base;
using AutoFramework.ConfigElement;

namespace AutoFramework.Config
{
    public class ConfigReader
    {
        public static void SetFrameworkSettings()
        {
            Settings.AUT = TestConfiguration.AutoSettings.TestSettings["staging"].AUT;
            //Settings.BuildName = buildname.Value.ToString();
            Settings.TestType = TestConfiguration.AutoSettings.TestSettings["staging"].TestType;
            Settings.IsLog = TestConfiguration.AutoSettings.TestSettings["staging"].IsLog;
            //Settings.IsReporting = TestConfiguration.AutoSettings.TestSettings["staging"].IsReadOnly;
            Settings.LogPath = TestConfiguration.AutoSettings.TestSettings["staging"].LogPath;
            Settings.AppConnectionString = TestConfiguration.AutoSettings.TestSettings["staging"].AUTDBConnectionString;
            Settings.BrowserType = (BrowserType)Enum.Parse(typeof(BrowserType), TestConfiguration.AutoSettings.TestSettings["staging"].Browser);
            Settings.DriverPath = TestConfiguration.AutoSettings.TestSettings["staging"].DriverPath;
        }

    }
}
