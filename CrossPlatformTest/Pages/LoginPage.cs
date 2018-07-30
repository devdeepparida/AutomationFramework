using AutoFramework.Base;
using OpenQA.Selenium;
using AutoFramework.Extensions;

namespace CrossPlatformEATest.Pages
{
    class LoginPage : BasePage
    {
        IWebElement txtUserName => DriverContext.Driver.FindElement(By.Id("UserName"));

        IWebElement txtPassword => DriverContext.Driver.FindElement(By.Id("Password"));

        IWebElement btnLogin => DriverContext.Driver.FindElement(By.CssSelector("input.btn"));


        public void Login(string userName, string password)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
        }


        public HomePage ClickLoginButton()
        {
            btnLogin.Submit();
            return GetInstance<HomePage>();
        }


        internal void CheckIfLoginExist()
        {
            txtUserName.AssertElementPresent();
        }
    }
}
