using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
using OpenQA.Selenium;
using OpenQA.Selenium.PhantomJS;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowNUnitDemo.Pages
{
    public class HomePage : BasePage
    {
        public HomePage()
            : base()
        {
           // webDriver = new PhantomJSDriver();
            webDriver.Url = baseUrl;
            webDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(secondTimeOut));
        }
        #region Elements

        private By contactUs = By.LinkText("Contact Us");

        #endregion

        #region Methods
        public void GotoContactUsPage()
        {
            webDriver.FindElement(contactUs).Click();
        }

        #endregion
    }
}
