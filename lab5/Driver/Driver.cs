using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Diagnostics;

namespace Testslab5.Driver
{
    class Driver
    {
        private static IWebDriver driver;
        private Driver() { }

        public static IWebDriver GetInstance()
        {
            if (driver == null)
            {
                driver = new ChromeDriver(@"D:\");
                driver.Manage().Window.Maximize();
            }
            return driver;
        }

        public static void CloseBrowser()
        {
            driver.Quit();
            driver = null;
            foreach (var process in Process.GetProcessesByName("geckodriver"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("chromedriver"))
            {
                process.Kill();
            }
        }
    }
}
