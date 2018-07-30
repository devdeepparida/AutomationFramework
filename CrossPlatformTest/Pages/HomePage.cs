using AutoFramework.Base;
using AutoFramework.Extensions;
using OpenQA.Selenium;

namespace CrossPlatformEATest.Pages
{
    internal class HomePage : BasePage
    {
        IWebElement lnkLogin => DriverContext.Driver.FindElement(By.LinkText("Login"));

        IWebElement lnkEmployeeList => DriverContext.Driver.FindElement(By.LinkText("Employee List"));

        IWebElement lnkLoggedInUser => DriverContext.Driver.FindElement(By.XPath("//a[@title='Manage']"));

        IWebElement lnkLogoff => DriverContext.Driver.FindElement(By.LinkText("Log off"));


        internal void CheckIfLoginExist() => lnkLogin.AssertElementPresent();


        internal LoginPage ClickLogin()
        {
            lnkLogin.Click();
            return GetInstance<LoginPage>();
        }

        internal string GetLoggedInUser() => lnkLoggedInUser.GetLinkText();

        public EmployeeListPage ClickEmployeeList()
        {
            lnkEmployeeList.Click();
            return GetInstance<EmployeeListPage>();
        }

        public LoginPage ClickLogOff()
        {
            lnkLogoff.Click();
            return GetInstance<LoginPage>();
        }
    }
}
