using System;
using OpenQA.Selenium;

namespace SeleniumPOM.Pages
{
    public class RegistrationPage :BaseApplicationPage
    {

        public RegistrationPage(IWebDriver driver) : base(driver)
        {
        }

        /*---- Web elements of Home page ----*/
        private IWebElement Firstname => Driver.FindElement(By.Id("name_3_firstname"));
        private IWebElement Lastname => Driver.FindElement(By.Id("name_3_lastname"));
    }
}
