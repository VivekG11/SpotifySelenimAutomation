using NUnit.Framework;
using AventStack.ExtentReports;
using SpotifyAutomationusingSelenium;

namespace SpotifyAutomationusingSelenium
{
    public class Tests : Base.BaseClass
    {
        ExtentReports reports = ReportClass.report();
        ExtentTest test;

        [Test]
        public  void Login()
        {
            test = reports.CreateTest("Tests");
            test.Log(Status.Info, "Automating Spotify Login PAge");
            Actions.Action.LoginToSpotify(driver);
            Assert.AreEqual(1, driver.WindowHandles.Count);

            test.Log(Status.Pass, "Test PAsses");

            reports.Flush();
        }
    }
}