using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisDarbas.Driver
{
    public class CustomDriver
    {
        public static IWebDriver GetChromeDriver()
        {
            return GetDriver("chrome"); 
        }

        public static IWebDriver GetFirefoxDriver()
        {
            return GetDriver("firefox"); 
        }

        public static IWebDriver GetEdgeDriver()
        {
            return GetDriver("edge");  
        }

        private static IWebDriver GetDriver(string browser)
        {
            IWebDriver driver = null;

            switch (browser)  //budas su switch (priskiriama narsykle)
            {
                case "chrome": 
                    driver = new ChromeDriver();
                    break;
                case "firefox": 
                    driver = new FirefoxDriver();
                    break;
                case "edge": 
                    driver = new EdgeDriver();
                    break;
                default:
                    driver = new ChromeDriver();
                    break;

            }



            if ("crome".Equals(browser))  //budas su if (priskiriama narsykle)
            {
                return new ChromeDriver();
            }
            if ("firefox".Equals(browser))
            {
                return new FirefoxDriver();
            }
            if ("edge".Equals(browser))
            {
                return new EdgeDriver();
            }
            driver.Manage().Window.Maximize();
            //driver.Manage().Timeouts().ImplicitWait = Timeouts.;
            return driver;



        }
    }
}
