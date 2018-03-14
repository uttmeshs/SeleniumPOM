using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace SeleniumPOM.Pages
{
    public class HomePage : BaseApplicationPage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        /*---- Web elements of Home page ----*/
        private IWebElement HomeButton => Driver.FindElement(By.LinkText("Home"));
        private IWebElement RegistrationButton => Driver.FindElement(By.LinkText("Registration"));

        internal void ClickOnRegistrationButton()
        {
            Assert.IsTrue(RegistrationButton.Displayed);
            RegistrationButton.Click();
        }


        internal void ClickOnIntrectionButtons(String ButtonName)
        {

            Assert.IsTrue(Driver.FindElement(By.LinkText(ButtonName)).Displayed);
            Driver.FindElement(By.LinkText(ButtonName)).Click();
        }

        internal void ClickOnHomeButton ()
        {
            Assert.IsTrue(HomeButton.Displayed);
            HomeButton.Click();
        }
    }
}
