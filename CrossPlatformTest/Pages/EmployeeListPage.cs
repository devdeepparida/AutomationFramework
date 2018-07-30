using AutoFramework.Base;
using OpenQA.Selenium;

namespace CrossPlatformEATest.Pages
{
    internal class EmployeeListPage : BasePage
    {
        IWebElement txtSearch => DriverContext.Driver.FindElement(By.Name("searchTerm"));

        IWebElement lnkCreateNew => DriverContext.Driver.FindElement(By.LinkText("Create New"));

        IWebElement tblEmployeeList => DriverContext.Driver.FindElement(By.ClassName("table"));

        IWebElement lnkLogoff => DriverContext.Driver.FindElement(By.LinkText("Log off"));

        public CreateEmployeePage ClickCreateNew()
        {
            lnkCreateNew.Click();
            return new CreateEmployeePage();
        }

        public IWebElement GetEmployeeList() => tblEmployeeList;

        internal void ClickLogoff() => lnkLogoff.Click();
    }
}
