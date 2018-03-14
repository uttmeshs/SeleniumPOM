using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumPOM.Pages;

namespace SeleniumPOM.Test
{
    [TestClass]
    public class PageNavigation : TestBase
    {
        [TestMethod]
        public void NavigationToPages()
        {
            String ButtonName = "Droppable";

            HomePage homePage = new HomePage(Driver);
            BaseApplicationPage baseApplicationPage = new BaseApplicationPage(Driver);

            Thread.Sleep(2000);
            baseApplicationPage.GoTO();

            homePage.ClickOnRegistrationButton();

            homePage.ClickOnIntrectionButtons(ButtonName);

            homePage.ClickOnHomeButton();

        }
    }
}
