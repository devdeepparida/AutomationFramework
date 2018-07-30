using AutoFramework.Base;
using CrossPlatformEATest.Pages;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace CrossPlatformEATest.Steps
{
    [Binding]
    class CreateEmployeeStep : BaseStep
    {

        [Then(@"I enter following details")]
        public void ThenIEnterFollowingDetails(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            CurrentPage.As<CreateEmployeePage>().CreateEmployee(data.Name,
                data.Salary.ToString(), data.DurationWorked.ToString(), data.Grade.ToString(), data.Email);

        }

        [Then(@"I create and delete user")]
        public void ThenICreateAndDeleteUser()
        {
            //ScenarioContext.Current.Pending();
        }


    }
}
