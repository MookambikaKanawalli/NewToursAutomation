using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;

namespace NewToursFrameworkAndTest.Framework
{
    public class BasePage
    {
        public BasePage()
        {
            PageFactory.InitElements(Base.Driver, this);
        }

    }
}
