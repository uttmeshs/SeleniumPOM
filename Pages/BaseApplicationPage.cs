using System;
using OpenQA.Selenium;

namespace SeleniumPOM.Pages

{
    public class BaseApplicationPage
    {
        protected IWebDriver Driver { get; set; }
        public BaseApplicationPage(IWebDriver driver)
        {
            Driver = driver;
        }

        internal void GoTO()
        {
            Driver.Navigate().GoToUrl("http://demoqa.com/");
        }
    }

}
