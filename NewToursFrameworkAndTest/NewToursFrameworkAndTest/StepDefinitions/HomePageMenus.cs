using TechTalk.SpecFlow;
using NewToursFrameworkAndTest.Framework;
using OpenQA.Selenium.Chrome;
using System.Threading;
using NewToursFrameworkAndTest.Pages;
using OpenQA.Selenium;
using log4net;

namespace NewToursFrameworkAndTest.StepDefinitions
{
    [Binding]
    public sealed class StepDefinition_HomePageMenus:BasePage
    {
        ILog logger = Logger.GetXmlLogger(typeof(StepDefinition_HomePageMenus));
        [Given(@"I am in home page of test application")]
        public void GivenIAmInHomePageOfTestApplication()
        {
           // DriverContext.Driver = new ChromeDriver();
            DriverContext.Driver.Manage().Window.Maximize();
            logger.Info("Opened the test application url");
            Thread.Sleep(2000);
        }
        [When(@"I select Registration menu")]
        public void WhenISelectRegistrationMenu()
        {
            CurrentPage = GetInstances<HomePage>();
            CurrentPage.As<HomePage>().ClickLink();
            logger.Info("Clicked on Registration link");
        }

        [Then(@"it should open Registration page")]
        public void ThenItShouldOpenRegistrationPage()
        {
            DriverContext.Driver.FindElement(By.Name("firstName"));
            logger.Info("Verified the existance of First name text box");
            Thread.Sleep(2000);
            
            logger.Info("Closed the application");
        }
    }
}
