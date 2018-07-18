using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
    class N11PageObject
    {
        public N11PageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        

        [FindsBy(How = How.Id, Using = "searchData")]
        public IWebElement txtSearch { get; set; }

        [FindsBy(How = How.ClassName, Using = "searchBtn")]
        public IWebElement btnSearch { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='contentListing']/div/div/div[2]/div[3]/a[2]")]
        public IWebElement btnGoToSecondPage { get; set; }

        [FindsBy(How = How.XPath, Using = "*[@id='header']/div/div[2]/div[3]/a[2]")]
        public IWebElement btnFav { get; set; }
        


    }
}
