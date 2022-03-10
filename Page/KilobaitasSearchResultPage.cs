using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisDarbas.Page
{
    public class KilobaitasSearchResultPage : BasePage
    {
        private const string PageAddress = "https://www.kilobaitas.lt/paieskos_rezultatai/searchresult.aspx?q=Pel%C4%97s";
        IReadOnlyCollection<IWebElement> result => Driver.FindElements(By.Id("yt_content"));
        private IWebElement productClick => Driver.FindElement(By.XPath("//div[@class='item-inner']//*[text()='MOUSE USB OPTICAL ZIVA/GAMING 21512 TRUST']"));

        private IWebElement produktName => Driver.FindElement(By.XPath("//h1[@itemprop='name']"));      

        public KilobaitasSearchResultPage(IWebDriver webdriver) : base(webdriver) { }

        public void NavigateToPage()
        {
            if (Driver.Url != PageAddress)
            {
                Driver.Url = PageAddress;
            }
        }

        public void List()
        {
            foreach (IWebElement item in result)
            {
                productClick.Click();
            }
        }

        public void ProduktName(string text)
        {
            Assert.AreEqual(text, produktName.Text, "Actual result differs from expected");
        }
    }
}
