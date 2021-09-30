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
    public class FavouritesPlaylist
    {
        public void AddToFavouritePlaylist(IWebDriver driver)
        {
            try
            {
                //Creating object for login class
                Favourites AddtoFav = new Favourites(driver);


                AddtoFav.userName.SendKeys("vivekvk2903@gmail.com");
                Thread.Sleep(2000);

                AddtoFav.pwd.SendKeys("Vivek@1313");
                Thread.Sleep(1000);

                AddtoFav.loginButton.Click();
                Thread.Sleep(2000);

                AddtoFav.webplayer.Click();
                Thread.Sleep(1000);

                //  Assert.AreEqual("https://www.spotify.com/in-en/account/overview/", driver.Url);

                driver.Navigate().GoToUrl("https://open.spotify.com/search");

                Base.BaseClass.Screenshot();
                Thread.Sleep(2000);

                AddtoFav.search.SendKeys(Keys.Control + "v");
                Thread.Sleep(2000);

                AddtoFav.album.SendKeys(Keys.Enter);
                Thread.Sleep(2000);

                AddtoFav.favourite.Click();
                Thread.Sleep(2000);

                AddtoFav.collection.Click();
                Thread.Sleep(2000);

                //Printing Current Window ID
                String currentWindowHandle = driver.CurrentWindowHandle;
                Console.WriteLine("CurrentWindow ID is " + currentWindowHandle);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
