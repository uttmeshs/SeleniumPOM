using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;


namespace SeleniumPOM.AutomationResource
{
    public class WebDriverFactory
    {
        public IWebDriver Create(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.Chrome:
                    return GetChromeDriver();
                default:
                    throw new ArgumentOutOfRangeException("No such browser exists");
            }
        }
        private IWebDriver GetChromeDriver()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            //var resourcesDirectory = Path.GetFullPath(Path.Combine(outPutDirectory, @"..\..\..\AutomationResources\bin\Debug"));
            return new ChromeDriver(outPutDirectory);
        }

    }
}
