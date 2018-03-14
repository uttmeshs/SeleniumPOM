using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumPOM.AutomationResource;
using OpenQA.Selenium;


namespace SeleniumPOM.Test
{
    [TestClass]
    public class TestBase
    {
        public IWebDriver Driver { get; private set; }

        [TestInitialize]
        public void SetupForEverySingleTestMethod()
        {
            var factory = new WebDriverFactory();
            Driver = factory.Create(BrowserType.Chrome);
        }

        [TestCleanup]
        public void CleanUpAfterEveryTestMethod()
        {
            Driver.Close();
            Driver.Quit();
        }
    }

}
