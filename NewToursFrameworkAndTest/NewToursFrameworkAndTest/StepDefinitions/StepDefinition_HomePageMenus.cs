using TechTalk.SpecFlow;
using NewToursFrameworkAndTest.Framework;
using OpenQA.Selenium.Chrome;
using System.Threading;
using NewToursFrameworkAndTest.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace NewToursFrameworkAndTest.StepDefinitions
{
    [Binding]
    public sealed class StepDefinition_HomePageMenus
    {
        [Given(@"I am in home page of test application")]
        public void GivenIAmInHomePageOfTestApplication()
        {
            Base.Driver = new ChromeDriver();
            Base.Driver.Manage().Window.Maximize();
            Base.Driver.Navigate().GoToUrl("http://newtours.demoaut.com/mercurywelcome.php");
            Thread.Sleep(2000);
        }
        [When(@"I select Registration menu")]
        public void WhenISelectRegistrationMenu()
        {
            HomePage hp = new HomePage();
            hp.ClickLink();
        }

        [Then(@"it should open Registration page")]
        public void ThenItShouldOpenRegistrationPage()
        {
            Base.Driver.FindElement(By.Name("firstName"));
            Thread.Sleep(2000);
            Base.Driver.Quit();
        }
    }
}
