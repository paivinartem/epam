using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Diagnostics;

namespace WebDriverLab.ChromeManager
{
   public static class ChromeManager
    {
        private static IWebDriver driver;

        private static readonly string DriverPath = AppContext.BaseDirectory.Replace(@"bin\Debug", "Chrome");
        private const string ChromeDriver = "chromedriver";

        public static IWebDriver GetDriver()
        {
            if (driver == null)
            {
                driver = new ChromeDriver(DriverPath);
            }
            return driver;
        }

        public static void Close()
        {
            driver.Quit();
            //driver = null;

            foreach (var process in Process.GetProcessesByName(ChromeDriver))
            {
                process.Kill();
            }
        }
    }
}
