using NUnit.Framework;
using OpenQA.Selenium;

namespace SeleniumTest.Scenerios
{
    public class LoginValidUsernamePassword
    {
        public IWebDriver Driver { get; set; }

        [OneTimeSetUp]
        public void Initialize()
        {
            Driver = Actions.InitializeDriver();
            NavigateTo.LoginForm(Driver);
        }

        [Test]
        public void Login()
        {
            Actions.FillLoginForm(Config.Credantials.Valid.Email, Config.Credantials.Valid.Password, Driver);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.Quit();
        }

    }
}
