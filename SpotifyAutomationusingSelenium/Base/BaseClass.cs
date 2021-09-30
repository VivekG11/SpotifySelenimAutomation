using System;
using System.IO;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using log4net;
using log4net.Repository;
using System.Reflection;

namespace SpotifyAutomationusingSelenium.Base
{
    public class BaseClass
    {
        public static IWebDriver driver;
       
        public static readonly ILog LogInfo = LogManager.GetLogger(typeof(Tests));
        public static readonly ILoggerRepository loggerRepository = LogManager.GetRepository(Assembly.GetCallingAssembly());

        [SetUp]
        public void Setup()
        {
            var file = new FileInfo("log4net.config");

            //logging info into file using XML configurator
            log4net.Config.XmlConfigurator.Configure(loggerRepository, file);

            try
            {
                //Logging Process info into file
                LogInfo.Info("Initializing SetUp");
                ChromeOptions options = new ChromeOptions();
                options.AddArgument("--disable-notifications");
                LogInfo.Info("Disabling notifications");
                driver = new ChromeDriver(options);
                LogInfo.Info("navigating control to chrome browser");

                driver.Manage().Window.Maximize();
                driver.Url = "https://accounts.spotify.com/en/login";
                Screenshot();
                LogInfo.Debug("Navigating to corresponding URL");
            }
            catch (Exception e)
            {
                 LogInfo.Error(e.Message);
            }
        }

        public static void Screenshot()
        {
            ITakesScreenshot ss = driver as ITakesScreenshot;
            Screenshot screenshot = ss.GetScreenshot();
            screenshot.SaveAsFile(@"C:\Users\vivek.g\source\repos\SpotifyAutomationusingSelenium\SpotifyAutomationusingSelenium\Screenshots\.jpg");
        }

        //[TearDown]
        //    public void tearDwon()
        //    {
        //        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1000);
        //        driver.Quit();
        //    }
    }
}
