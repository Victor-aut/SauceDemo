using OpenQA.Selenium;
using SauceDemo.UITests.Support;

namespace SauceDemo.UITests.Pages
{
    public class LoginPage
    {
        #region IWebElement

        private By Username = By.Id("user-name");
        private By Password = By.Id("password");
        private By LoginBtn = By.Id("login-button");

        #endregion

        #region Actions

        public void GoToUrl(string url)
        {
            Repository.Driver.Navigate().GoToUrl(url);
            Repository.Driver.Manage().Window.Maximize();
            Repository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public void Login(string username, string password)
        {
            Repository.Driver.FindElement(Username).SendKeys(username);
            Repository.Driver.FindElement(Password).SendKeys(password);
            Repository.Driver.FindElement(LoginBtn).Click();
        }

        #endregion

    }
}
