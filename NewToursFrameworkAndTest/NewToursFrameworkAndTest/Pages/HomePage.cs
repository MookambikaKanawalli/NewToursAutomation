using NewToursFrameworkAndTest.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace NewToursFrameworkAndTest.Pages
{
    public class HomePage:BasePage
    {
        [FindsBy(How = How.LinkText, Using = "REGISTER")]
        [CacheLookup]
        public IWebElement lnkRegistration { get; set; }

        public void ClickLink()
        {
            lnkRegistration.Click();
        }
    }
}
