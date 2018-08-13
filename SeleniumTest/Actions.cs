using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTest.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
    public class Actions
    {
        public static IWebDriver InitializeDriver()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Config.BaseURL);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            return driver;
        }

        public static void FillLoginForm(string username, string password, IWebDriver driver)
        {
            var login = new LoginPage(driver);

            login.UserNameField.Clear();
            login.UserNameField.SendKeys(username);

            login.PasswordField.Clear();
            login.PasswordField.SendKeys(password);

            login.LoginButton.Click();
        }

        public static void SearchForSamsung(string value, IWebDriver driver)
        {
            var menu = new Menu(driver);

            menu.TextboxSearch.SendKeys(value);
            menu.SearchButton.Click();
        }

        public static void AddToFavorites(IWebDriver driver)
        {
            var menu = new Menu(driver);

            menu.ThirdItem.Click();
        }
    }
}
