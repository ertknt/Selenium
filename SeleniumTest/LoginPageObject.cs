using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
    class LoginPageObject
    {
        public LoginPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "btnSignIn")]
        public IWebElement btnSignIn { get; set; }

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement txtEmail { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Id, Using = "loginButton")]
        public IWebElement btnLogin { get; set; }

        public void Login(string userName,string password)
        {
            btnSignIn.Click();
            //username
            txtEmail.SendKeys(userName);
            //password
            txtPassword.SendKeys(password);
            //login
            btnLogin.Click();
            
        }

    }
}
