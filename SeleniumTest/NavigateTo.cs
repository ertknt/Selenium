using OpenQA.Selenium;
using SeleniumTest.Pages;

namespace SeleniumTest
{
    public class NavigateTo
    {
        public static void MainPage(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(Config.BaseURL);
        }

        public static void LoginForm(IWebDriver driver)
        {
            var Menu = new Menu(driver);

            Menu.Login.Click();
        }

        public static void SecondPage(IWebDriver driver)
        {
            var Menu = new Menu(driver);

            Menu.SecondPage.Click();
        }

        public static void MyFavorites(IWebDriver driver)
        {
            var Menu = new Menu(driver);
            var MyAccount = new MyAccount(driver);
            var WishList = new WishList(driver);

            Menu.MyAccount.Click();
            MyAccount.WishList.Click();
            WishList.MyFavorites.Click();
        }
    }
}
