using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;

namespace SpotifyAutomationusingSelenium.Login
{
    public class LoginPage
    {

        public LoginPage(IWebDriver driver)
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

        //[FindsBy(How = How.ClassName, Using = "CPgTPk9wPOVigmNI6xWP")]
        //[CacheLookup]
        //public IWebElement search;
    }
}
