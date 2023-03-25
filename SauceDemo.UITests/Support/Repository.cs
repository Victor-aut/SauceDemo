using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SauceDemo.UITests.Support
{
    public class Repository
    {
        public static IWebDriver Driver = new ChromeDriver();
    }
}
