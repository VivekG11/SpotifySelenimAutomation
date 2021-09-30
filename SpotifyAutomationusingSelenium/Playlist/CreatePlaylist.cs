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

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main\"]/div/div[2]/div[1]/header/div[3]/div/div/form/input")]
        [CacheLookup]
        public IWebElement search;

        [FindsBy(How = How.ClassName, Using = "__vD2WIw7hKoSpsLS4G7")]
        [CacheLookup]
        public IWebElement album;

        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/div/div[2]/div[3]/main/div[2]/div[2]/div/div/div[2]/section/div[2]/div[3]/div/div[2]/div[2]/div[1]/div/div[5]/button[2]")]
        [CacheLookup]
        public IWebElement add;

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[4]/div[1]/div[2]/nav[1]/div[1]/div[2]/div[1]/div[1]/button[1]/div[1]")]
        [CacheLookup]
        public IWebElement creatbtn;
    }
}
