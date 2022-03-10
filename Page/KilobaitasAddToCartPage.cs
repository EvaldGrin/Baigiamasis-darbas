using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisDarbas.Page
{
    public class KilobaitasAddToCartPage : BasePage
    {
        private const string PageAddress = "https://www.kilobaitas.lt/tinklo_gsm_gps_iranga/telefonai_ir_priedai/mobilieji_telefonai/mobile_phone_galaxy_a03s32gb_black_sm-a037g_samsung__sm-a037gzkneue/product.aspx?itemid=650791";
        private IWebElement addButton => Driver.FindElement(By.CssSelector("#lytA_ctl08_buttonToCart > span"));
        private IWebElement cartIcon => Driver.FindElement(By.Id("cartRound"));
        private IWebElement buyButton => Driver.FindElement(By.CssSelector("#priceLabel > button"));
        private IWebElement riseValue => Driver.FindElement(By.Id("qtyAdd-650791__"));
        private IWebElement assertPrice => Driver.FindElement(By.CssSelector("#shopping-cart-table > tbody > tr > td:nth-child(5) > span"));

        public KilobaitasAddToCartPage(IWebDriver webDriver) : base(webDriver) { }

        public void NavigateToPage()
        {
            if (Driver.Url != PageAddress)
            {
                Driver.Url = PageAddress;
            }
        }

        public void AddToChart()
        {
            addButton.Click();
        }


        public void OverCartButton()
        {
            Actions actionProvider = new Actions(Driver);
            actionProvider.MoveToElement(cartIcon).Build().Perform();
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(2));

        }
        public void BuyButton()
        {
            buyButton.Click();
        }

        public void IncreasValue()
        {
            riseValue.Click();
        }

        public void AssertValue(string text)
        {
            Assert.AreEqual(text, assertPrice.Text, "Blogai suskaiciuota kaina!");
        }
    }
}
