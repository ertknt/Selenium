using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumTest.Pages
{
    public class LoginPage
    {
        public LoginPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement UserNameField { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement PasswordField { get; set; }

        [FindsBy(How = How.Id, Using = "loginButton")]
        public IWebElement LoginButton { get; set; }
    }
}
