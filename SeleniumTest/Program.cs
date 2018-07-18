using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SeleniumTest
{
    class Program
    {
        //initialize the page
        

        static void Main(string[] args)
        {

        }

        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver();
            //navigate to n11 page
            PropertiesCollection.driver.Navigate().GoToUrl("https://www.n11.com");
            Console.WriteLine("Navigated to the main page.");
        }

        [Test]
        public void LoginTest()
        {
            //login to site
            LoginPageObject pageLogin = new LoginPageObject();
            pageLogin.Login("ertankanter@gmail.com", "177901Ab");
        }

        [Test]
        public void SearchTest()
        {
            N11PageObject page = new N11PageObject();
            page.txtSearch.SendKeys("Samsung");
            page.btnSearch.Click();
            
            Console.WriteLine("searched Samsung");
        }

        [Test]
        public void GoToSecondPageTest()
        {
            N11PageObject page = new N11PageObject();
            page.btnGoToSecondPage.Click();
            Console.WriteLine("This is the second page.");
            
        }

        [Test]
        public void GoToFavorites()
        {
            N11PageObject page = new N11PageObject();
            page.btnFav.Click();
        }

        [TearDown]
        public void Clean()
        {
            PropertiesCollection.driver.Close();
            Console.WriteLine("Browser closed.");
        }
    }
}
