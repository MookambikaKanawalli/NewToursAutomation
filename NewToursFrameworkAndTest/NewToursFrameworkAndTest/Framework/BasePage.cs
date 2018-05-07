using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;

namespace NewToursFrameworkAndTest.Framework
{
    public class BasePage:Base
    {
        private IWebDriver _driver;
        public BasePage()
        {
            PageFactory.InitElements(DriverContext.Driver, this);
        }

        public TPage GetInstances<TPage>() where TPage:BasePage, new()
        {
            TPage pageInstance = new TPage()
            {
                _driver = DriverContext.Driver
            };
            PageFactory.InitElements(DriverContext.Driver, pageInstance);
            return pageInstance;
        }

        public TPage As<TPage>() where TPage: BasePage
        {
            return (TPage)this;
        }
    }
}
