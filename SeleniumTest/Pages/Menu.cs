using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumTest.Pages
{
    public class Menu
    {
        public Menu(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "btnSignIn")]
        public IWebElement Login { get; set; }

        [FindsBy(How = How.ClassName, Using = "menuTitle")]
        public IWebElement MyAccount { get; set; }

        [FindsBy(How = How.Id, Using = "searchData")]
        public IWebElement TextboxSearch { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#header>div>div>div.hMedMenu>div.searchBox.withLocalization>a>span")]
        public IWebElement SearchButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"contentListing\"]/div/div/div[2]/div[3]/a[2]")]
        public IWebElement SecondPage { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"p-239634812\"]/div[2]/span[2]")]
        public IWebElement ThirdItem { get; set; }


    }
}
