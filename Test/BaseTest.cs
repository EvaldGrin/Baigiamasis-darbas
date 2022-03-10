using BaigiamasisDarbas.Driver;
using BaigiamasisDarbas.Page;
using BaigiamasisDarbas.Tools;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisDarbas.Test
{
    public class BaseTest
    {
        protected static IWebDriver driver;
        protected static KilobaitasHomePage _kilobaitasHomePage;
        protected static KilobaitasSearchResultPage _kilobaitasSearchResultPage;
        protected static KilobaitasAddToCartPage _kilobaitasAddToCartPage;
        protected static KilobaitasLoginPage _kilobaitasLoginPage;
        protected static KilobaitasAddressPage _kilobaitasAddressPage;

        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
            driver = CustomDriver.GetChromeDriver();
            _kilobaitasHomePage = new KilobaitasHomePage(driver);
            _kilobaitasSearchResultPage = new KilobaitasSearchResultPage(driver);
            _kilobaitasAddToCartPage = new KilobaitasAddToCartPage(driver);
            _kilobaitasLoginPage = new KilobaitasLoginPage(driver);
            _kilobaitasAddressPage = new KilobaitasAddressPage(driver);
        }

        [TearDown]
        public static void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                MyScreenshot.TakeScreenshot(driver);
            }
        }


        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            driver.Quit();
        }
    }
}
