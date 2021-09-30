using NUnit.Framework;
using OpenQA.Selenium;
using SpotifyAutomationusingSelenium.Login;
using System.Threading;
using System;
using SpotifyAutomationusingSelenium.AddToFavourites;
using SpotifyAutomationusingSelenium.Playlist;
using AutoItX3Lib;

namespace SpotifyAutomationusingSelenium.Actions
{
    public class Action 
    {
        public static IWebDriver driver { get; set; }
        //Asserting Title of the application after launching browser
        public void AssertTitleAfterSearchingApplication(IWebDriver driver)
        {
            string title1 = "Login - Spotify";
            string title = driver.Title;
            Assert.AreEqual(title1, title);
        }

        public  void LoginToSpotify(IWebDriver driver)
        {
            try
            {
                //Creating object for login class
                LoginPage login = new LoginPage(driver);

                driver.Url = "https://accounts.spotify.com/en/login";

                login.userName.SendKeys("vivekvk2903@gmail.com");
                Thread.Sleep(2000);

                login.pwd.SendKeys("Vivek@1313");
                Thread.Sleep(1000);

                login.loginButton.Click();
                Thread.Sleep(1000);

                login.webplayer.Click();
                Thread.Sleep(1000);

                Assert.AreEqual("https://www.spotify.com/in-en/account/overview/", driver.Url);

                Base.BaseClass.Screenshot();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public void CreateNewPlaylist(IWebDriver driver)
        {
            //try
            //{ 
            //Creating object for CreatePlaylist class
            CreatePlaylist playlist = new CreatePlaylist(driver);

            playlist.userName.SendKeys("vivekvk2903@gmail.com");
            Thread.Sleep(2000);

            playlist.pwd.SendKeys("Vivek@1313");
            Thread.Sleep(1000);

            playlist.loginButton.Click();
            Thread.Sleep(2000);

            playlist.webplayer.Click();
            Thread.Sleep(2000);

            driver.Navigate().GoToUrl("https://open.spotify.com/search");
            Thread.Sleep(3000);

            playlist.search.SendKeys(Keys.Control + "v");
            Thread.Sleep(2000);

            playlist.album.SendKeys(Keys.Enter);
            Thread.Sleep(2000);

            playlist.add.Click();
            Thread.Sleep(2000);

            playlist.creatbtn.SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //}
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e.Message);
            //    }
        }
    }
}
