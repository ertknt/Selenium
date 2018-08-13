using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumTest.Pages
{
   public class MyAccount
    {
        public MyAccount(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#myAccount>div.accMenu>div.accMenu-cover>div.accNav>ul>li.active>a")]
        public IWebElement WishList { get; set; }
    }
}
