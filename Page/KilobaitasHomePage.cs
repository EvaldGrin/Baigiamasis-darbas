using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisDarbas.Page
{
    public class KilobaitasHomePage : BasePage
    {
        private const string PageAddress = "https://www.kilobaitas.lt/";
        private IWebElement searchField => Driver.FindElement(By.Id("search"));
        private IWebElement searchClick => Driver.FindElement(By.Id("lytA_ctl23_searchBtn"));
        private IWebElement result => Driver.FindElement(By.CssSelector("#lytA_ctl26_UpdatePanel > div.category-products > div.products-grid.row > div > div > div.item-info.item-align > div.item-title.line-clamp > a > p"));
        public KilobaitasHomePage(IWebDriver webdriver) : base(webdriver) { }

        public void NavigateToPage()
        {
            if (Driver.Url != PageAddress)
            {
                Driver.Url = PageAddress;
            }
        }

        public void SearchText()
        {
            searchField.Clear();
            searchField.SendKeys("HP 32s 32inch display | 2UD96AA#ABB");
        }

        public void SearchClick()
        {
            searchClick.Click();
        }

        public void ResultsText(string text)
        {
            Assert.AreEqual(text, result.Text, "Actual result differs from expected");
        }
    }
}
