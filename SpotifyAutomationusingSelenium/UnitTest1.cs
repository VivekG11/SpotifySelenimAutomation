
/*
 * project = Selenium Croee Browser Testing
 * Author = G Vivek
 */

using NUnit.Framework;
using AventStack.ExtentReports;
using System.Collections.Generic;
using SpotifyAutomationusingSelenium.Actions;

namespace SpotifyAutomationusingSelenium
{
    [TestFixture]
    public class Tests : Base.BaseClass
    {

        //creating instance of ExtentReports class to create report file
        ExtentReports reports = ReportClass.report();
        ExtentTest test;

        [Test]
        public void Login()
        {
            test = reports.CreateTest("Tests");
            test.Log(Status.Info, "Automating Spotify Login PAge");

            Action action = new Action();

            action.AssertTitleAfterSearchingApplication(driver);

            action.LoginToSpotify(driver);

            Screenshot();

            test.Info("Details", MediaEntityBuilder.CreateScreenCaptureFromPath(@"C:\Users\vivek.g\source\repos\SpotifyAutomationusingSelenium\SpotifyAutomationusingSelenium\Screenshots\ss1.jpg").Build());

            Assert.AreEqual(1, driver.WindowHandles.Count);

            test.Log(Status.Pass, "Test PAsses");

            reports.Flush();
        }
        [Test]
        public void AddToFavourites()
        {
            test = reports.CreateTest("Tests");
            test.Log(Status.Info, "Automating Spotify Login PAge");

            Action action = new Action();
            action.FavouritePlaylist(driver);

            Screenshot();

            test.Info("Details", MediaEntityBuilder.CreateScreenCaptureFromPath(@"C:\Users\vivek.g\source\repos\SpotifyAutomationusingSelenium\SpotifyAutomationusingSelenium\Screenshots\ss2.jpg").Build());

            Assert.AreEqual(1, driver.WindowHandles.Count);

            test.Log(Status.Pass, "Test PAsses");

            reports.Flush();

        }

        [Test]
        public void NewPlaylist()
        {
            Action action = new Action();
            action.CreateNewPlaylist(driver);
        }
    }
    [TestFixture]
    [Parallelizable]
    public class ChromeTesting : CrossBrowsers
    {
        public ChromeTesting():base(Browsers.Chrome)
        {

        }

        [Test]
        public void ChromeTest()
        {
            Action action = new Action();
            action.LoginToSpotify(driver);
        }
    }

    [TestFixture]
    [Parallelizable]
    public class FireFoxTesting : CrossBrowsers
    {
        public FireFoxTesting() : base(Browsers.Firefox)
        {

        }

        [Test]
        public void FireFoxTest()
        {
            Action action = new Action();
            action.LoginToSpotify(driver);
        }
    }

    [TestFixture]
    [Parallelizable]
    public class IETesting : CrossBrowsers
    {
        public IETesting() : base(Browsers.IE)
        {

        }

        [Test]
        public void IETest()
        {
            Action action = new Action();
            action.LoginToSpotify(driver);
        }
    }
}