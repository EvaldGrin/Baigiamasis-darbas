using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisDarbas.Test
{
    public class KilobaitasTest : BaseTest
    {
        [Test]
        public static void TestKilobaitasSearch()
        {
            _kilobaitasHomePage.NavigateToPage();
            _kilobaitasHomePage.SearchText();
            _kilobaitasHomePage.SearchClick();
            _kilobaitasHomePage.ResultsText("HP 32s 32inch display | 2UD96AA#ABB");
        }

        [Test]

        public static void TestKilobaitasIteomFormList()
        {
            _kilobaitasSearchResultPage.NavigateToPage();
            _kilobaitasSearchResultPage.List();
            _kilobaitasSearchResultPage.ProduktName("MOUSE USB OPTICAL ZIVA/GAMING 21512 TRUST");
        }

        [Test]

        public static void TestKilobaitasaddToCart()
        {
            _kilobaitasAddToCartPage.NavigateToPage();
            _kilobaitasAddToCartPage.AddToChart();
            _kilobaitasAddToCartPage.OverCartButton();
            _kilobaitasAddToCartPage.BuyButton();
            _kilobaitasAddToCartPage.IncreasValue();
            _kilobaitasAddToCartPage.AssertValue("338,82 €");
        }

        [Test]
        public static void KilobaitasLoginTest()
        {
            _kilobaitasLoginPage.NavigateToPage();
            _kilobaitasLoginPage.LoginButton();
            _kilobaitasLoginPage.UserFields();
            _kilobaitasLoginPage.PasswordField();
            _kilobaitasLoginPage.LogButton();
            _kilobaitasLoginPage.AssertLogin("Atsijungti");
            _kilobaitasLoginPage.LogoutButton();

        }

        [Test]
        public static void KilobaitasWorkingDays()
        {
            _kilobaitasAddressPage.NavigateToPage();
            _kilobaitasAddressPage.OverSalonAddress();
            _kilobaitasAddressPage.SelectCity();
            _kilobaitasAddressPage.ResultsText("VI       10 - 17");
        }
    }
}
