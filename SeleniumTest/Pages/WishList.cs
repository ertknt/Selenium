using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumTest.Pages
{
    public class WishList
    {
        public WishList(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "listItemTitle")]
        public IWebElement MyFavorites { get; set; }
    }
}
