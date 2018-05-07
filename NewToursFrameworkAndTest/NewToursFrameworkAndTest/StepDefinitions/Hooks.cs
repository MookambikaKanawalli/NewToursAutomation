using NewToursFrameworkAndTest.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace NewToursFrameworkAndTest.StepDefinitions
{
    [Binding]
    public sealed class Hooks
    {
        IWebDriver _driver;
        [BeforeScenario]
        public void BeforeScenario()
        {
            Browsers br = new Browsers();
            _driver = DriverContext.Driver;
            DriverContext.Driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["AppUrl"]);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            DriverContext.Driver.Quit();
        }
    }
}
