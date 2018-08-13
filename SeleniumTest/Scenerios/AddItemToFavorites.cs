using NUnit.Framework;
using OpenQA.Selenium;

namespace SeleniumTest.Scenerios
{
    public class AddItemToFavorites
    {
        public IWebDriver Driver { get; set; }

        [OneTimeSetUp]
        public void Initialize()
        {
            Driver = Actions.InitializeDriver();
            NavigateTo.LoginForm(Driver);
            Actions.FillLoginForm(Config.Credantials.Valid.Email, Config.Credantials.Valid.Password, Driver);
            Actions.SearchForSamsung(Config.SeachKey, Driver);
            NavigateTo.SecondPage(Driver);
        }

        [Test]
        public void AddToFavorites()
        {
            Actions.AddToFavorites(Driver);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.Quit();
        }
    }
}
