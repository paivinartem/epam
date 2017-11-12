using NUnit.Framework;
using WebDriverLab.Step;

namespace WebDriverLab
{
    [TestFixture]
    public class WebDriver
    {
        Login loginStep;

        [SetUp]
        public void Init()
        {
            loginStep = new Login();
            loginStep.InitStep();
        }

        [Test]
        public void RunWebDriver()
        {          
            loginStep.LogIn();
        }

        [TearDown]
        public void Cleanup()
        {
            loginStep.EndStep();
        }

    }
}
