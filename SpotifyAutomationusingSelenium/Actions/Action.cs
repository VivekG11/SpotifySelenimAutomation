using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using SpotifyAutomationusingSelenium.Login;
using System;

namespace SpotifyAutomationusingSelenium.Actions
{
    public class Action
    {
        public static void LoginToSpotify(IWebDriver driver)
        {
            LoginPage login = new LoginPage(driver);


            login.userName.SendKeys("vivekvk2903@gmail.com");
            System.Threading.Thread.Sleep(2000);

            login.pwd.SendKeys("Vivek@1313");
            System.Threading.Thread.Sleep(1000);

            login.loginButton.Click();
           // Screenshot();
            System.Threading.Thread.Sleep(1000);


            login.webplayer.Click();
            System.Threading.Thread.Sleep(1000);

            driver.Navigate().GoToUrl("https://open.spotify.com/search/Master%20Theme");
          //  Screenshot();
            System.Threading.Thread.Sleep(1000);

          //  login.search.SendKeys(Keys.Control + "v");

            String currentWindowHandle = driver.CurrentWindowHandle;
            Console.WriteLine("CurrentWindow ID is " + currentWindowHandle);


        }
    }
}
