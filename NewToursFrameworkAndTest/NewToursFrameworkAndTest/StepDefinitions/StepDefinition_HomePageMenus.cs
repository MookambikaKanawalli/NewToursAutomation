using TechTalk.SpecFlow;
using NewToursFrameworkAndTest.Framework;
using OpenQA.Selenium.Chrome;
using System.Threading;
using NewToursFrameworkAndTest.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using log4net;

namespace NewToursFrameworkAndTest.StepDefinitions
{
    [Binding]
    public sealed class StepDefinition_HomePageMenus
    {
        ILog logger = Logger.GetXmlLogger(typeof(StepDefinition_HomePageMenus));
        [Given(@"I am in home page of test application")]
        public void GivenIAmInHomePageOfTestApplication()
        {
            DriverContext.Driver = new ChromeDriver();
            DriverContext.Driver.Manage().Window.Maximize();
            DriverContext.Driver.Navigate().GoToUrl("http://newtours.demoaut.com/mercurywelcome.php");
            logger.Info("Opened the test application url");
            Thread.Sleep(2000);
        }
        [When(@"I select Registration menu")]
        public void WhenISelectRegistrationMenu()
        {
            HomePage hp = new HomePage();
            logger.Info("created home page object");
            hp.ClickLink();
            logger.Info("Clicked on Registration link");
        }

        [Then(@"it should open Registration page")]
        public void ThenItShouldOpenRegistrationPage()
        {
            DriverContext.Driver.FindElement(By.Name("firstName"));
            logger.Info("Verified the existance of First name text box");
            Thread.Sleep(2000);
            DriverContext.Driver.Quit();
            logger.Info("Closed the application");
        }
    }
}
