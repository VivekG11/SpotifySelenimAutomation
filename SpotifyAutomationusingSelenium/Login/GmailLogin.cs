using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SpotifyAutomationusingSelenium.Login
{
    public class GmailLogin
    {
        public GmailLogin(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/header[1]/div[1]/div[1]/div[1]/a[2]")]
        [CacheLookup]
        public IWebElement signin;

        [FindsBy(How = How.Name, Using = "identifier")]
        [CacheLookup]
        public IWebElement userName;

        [FindsBy(How = How.Id, Using = "identifierNext")]
        [CacheLookup]
        public IWebElement next;

        [FindsBy(How = How.XPath, Using = "//*[@class='whsOnd zHQkBf']")]
        [CacheLookup]
        public IWebElement pwd;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Next')]")]
        [CacheLookup]
        public IWebElement Next;
               
        [FindsBy(How = How.XPath, Using = "//body/div[7]/div[3]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]")]
        [CacheLookup]
        public IWebElement Compose;

        [FindsBy(How = How.Name, Using = "to")]
        [CacheLookup]
        public IWebElement ToBtn;

        [FindsBy(How = How.Name, Using = "subjectbox")]
        [CacheLookup]
        public IWebElement Subject;

        [FindsBy(How = How.XPath, Using = "//*[@class='a1 aaA aMZ']")]
        [CacheLookup]
        public IWebElement Attach;

        [FindsBy(How = How.XPath, Using = "//*[@class='T-I J-J5-Ji aoO v7 T-I-atl L3']")]
        [CacheLookup]
        public IWebElement Send;

    }
}
