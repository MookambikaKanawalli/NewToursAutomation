using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace NewToursFrameworkAndTest.Framework
{
    public class Browsers
    {
        public Browsers()
        {
            LoadBrowser(ConfigurationManager.AppSettings["Browser"]);
        }
        public enum Browser
        {
            Chrome,
            InternetExplorer,
            Safari,
            Firefox
        }

        public void LoadBrowser(string browser)
        {
            if (browser.ToLower().Equals("chrome"))
            {
                DriverContext.Driver = new ChromeDriver();
            }
            else if(browser.ToLower().Equals("firefox"))
            {
                DriverContext.Driver = new FirefoxDriver();
            }
            else if (browser.ToLower().Equals("internetexplorer"))
            {
                DriverContext.Driver = new InternetExplorerDriver();
            }
            else
            {
                DriverContext.Driver = new ChromeDriver();
            }
        }
    }
}
