using NUnit.Framework;
using OpenQA.Selenium;

namespace SeleniumTest.Scenerios
{
    public class SearchForSamsung
    {
        public IWebDriver Driver { get; set; }

        [OneTimeSetUp]
        public void Initialize()
        {
            Driver = Actions.InitializeDriver();
            NavigateTo.LoginForm(Driver);
            Actions.FillLoginForm(Config.Credantials.Valid.Email, Config.Credantials.Valid.Password, Driver);
        }

        [Test]
        public void SeachForSamsung()
        {
            Actions.SearchForSamsung(Config.SeachKey, Driver);
            NavigateTo.SecondPage(Driver);
        }

        

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.Quit();
        }
    }
}
