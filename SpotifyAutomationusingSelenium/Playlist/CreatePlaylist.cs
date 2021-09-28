using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SpotifyAutomationusingSelenium.Playlist
{
    public class CreatePlaylist
    {
        public CreatePlaylist(IWebDriver driver)
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

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[2]/div[1]/div[1]/div[4]/div[1]/a[1]")]
        [CacheLookup]
        public IWebElement webplayer;

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[4]/div[1]/div[2]/nav[1]/div[1]/div[2]/div[1]/div[1]")]
        [CacheLookup]
        public IWebElement creatbtn;
    }
}
