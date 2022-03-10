using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisDarbas.Page
{
    public class KilobaitasLoginPage : BasePage
    {
        private const string PageAddress = "https://www.kilobaitas.lt/";
        private IWebElement logIn => Driver.FindElement(By.CssSelector("#lytA_ctl08_LogIn > b"));
        private IWebElement userField => Driver.FindElement(By.CssSelector("#lytA_ctl08_UserName"));
        private IWebElement passwordField => Driver.FindElement(By.Id("lytA_ctl08_Password"));
        private IWebElement loginButton => Driver.FindElement(By.Id("lytA_ctl08_LoginButton"));
        private IWebElement assertLog => Driver.FindElement(By.CssSelector("#lytA_ctl09_LogOut > b"));
        private IWebElement logOffButton => Driver.FindElement(By.Id("lytA_ctl09_LogOut"));

        public KilobaitasLoginPage(IWebDriver webdriver) : base(webdriver) { }



        public void NavigateToPage()
        {
            if (Driver.Url != PageAddress)
            {
                Driver.Url = PageAddress;
            }
        }

        public void LoginButton()
        {
            logIn.Click();
        }

        public void UserFields()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(2)); //Explicit wait-laukia konkretaus elemento
            wait.Until(d => d.FindElement(By.CssSelector("#modal-login > div > div")).Displayed);
            userField.Clear();
            userField.SendKeys("e-mail address");
        }

        public void PasswordField()
        {
            passwordField.Clear();
            passwordField.SendKeys("password");
        }

        public void LogButton()
        {
            loginButton.Click();
        }

        public void AssertLogin(string text)
        {
            Assert.AreEqual(text, assertLog.Text, "Jus neprisijunges!");
        }

        public void LogoutButton()
        {
            logOffButton.Click();
        }
    }
}
