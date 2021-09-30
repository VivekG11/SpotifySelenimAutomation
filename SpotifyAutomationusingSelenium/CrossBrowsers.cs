using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using NUnit.Framework;

namespace SpotifyAutomationusingSelenium
{
    public enum Browsers
    {
        Chrome, Firefox,IE
    }
    public class CrossBrowsers :Actions.Action
    {
       private Browsers browserType;

      //Creating constructor of class with Browsers as paramter
      public CrossBrowsers(Browsers browser)
        {
            browserType = browser;
        }

        [SetUp]
        public void TestSetup()
        {
            SelectBrowser(browserType);
        }

        public void SelectBrowser(Browsers driverType)
        {
            if (driverType == Browsers.Chrome)
                driver = new ChromeDriver();
            else if (driverType == Browsers.Firefox)
                driver = new FirefoxDriver();
            else driver = new InternetExplorerDriver();
        }
    }
}
