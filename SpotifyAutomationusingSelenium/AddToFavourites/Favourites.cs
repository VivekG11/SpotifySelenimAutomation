using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SpotifyAutomationusingSelenium.AddToFavourites
{
    public class Favourites
    {
        public Favourites(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Name, Using = "username")]
        [CacheLookup]
        public IWebElement userName;

        [FindsBy(How = How.Id, Using = "login-password")]
        [CacheLookup]
        public IWebElement pwd;

        [FindsBy(How = How.Id, Using = "login-button")]
        [CacheLookup]
        public IWebElement loginButton;

        [FindsBy(How = How.ClassName, Using = "col-xs-12")]
        [CacheLookup]
        public IWebElement webplayer;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main\"]/div/div[2]/div[1]/header/div[3]/div/div/form/input")]
        [CacheLookup]
        public IWebElement search;

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[4]/div[1]/div[2]/div[3]/main[1]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/section[3]/div[2]/div[3]/div[1]/div[2]/a[1]")]
        [CacheLookup]
        public IWebElement album;

        [FindsBy(How = How.ClassName, Using = "B77TpDT6WaoYUqQxvy4Z")]
        [CacheLookup]
        public IWebElement favourite;

        [FindsBy(How = How.ClassName, Using = "CY8Z5OJX7wXdnPM1vRVz")]
        [CacheLookup]
        public IWebElement collection;
    }
}
