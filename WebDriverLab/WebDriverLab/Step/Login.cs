using OpenQA.Selenium;

namespace WebDriverLab.Step
{
    public class Login
    {
        private IWebDriver driver;

        public void InitStep()
        {
            driver = ChromeManager.ChromeManager.GetDriver();
            ChromeManager.ChromeManager.GetDriver();
            driver.Url = "http://www.github.com/login";
        }

        public void EndStep()
        {
            ChromeManager.ChromeManager.Close();
        }

        public void LogIn()
        {
            var loginPage = new Page.LoginPage(driver);
            loginPage.LogIn();
        }

    }
}
