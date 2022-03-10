using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisDarbas.Page
{
    public class KilobaitasAddressPage : BasePage
    {
        private const string PageAddress = "https://www.kilobaitas.lt/";
        private IWebElement address => Driver.FindElement(By.XPath("//b[text()='Mūsų salonai']"));

        private IWebElement dropdown => Driver.FindElement(By.XPath("//a[text()='Kaunas']"));

        private IWebElement workingday => Driver.FindElement(By.XPath("//p[contains(text(),'10 - 17')]"));


        public KilobaitasAddressPage(IWebDriver webDriver) : base(webDriver) { }


        public void NavigateToPage()
        {
            if (Driver.Url != PageAddress)
            {
                Driver.Url = PageAddress;
            }
        }

        public void OverSalonAddress()
        {
            Actions actionProvider = new Actions(Driver);
            actionProvider.MoveToElement(address).Build().Perform();
        }

        public void SelectCity()
        {
            dropdown.Click();
        }

        public void ResultsText(string text)
        {
            Assert.AreEqual(text, workingday.Text, "Sekmadieni dirbame");
        }
    }
}
