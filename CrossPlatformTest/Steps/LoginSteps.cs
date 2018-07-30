using AutoFramework.Base;
using CrossPlatformEATest.Pages;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace CrossPlatformEATest.Steps
{
    [Binding]
    public class LoginSteps : BaseStep
    {

        [When(@"I enter UserName and Password")]
        public void WhenIEnterUserNameAndPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            CurrentPage.As<LoginPage>().Login(data.UserName, data.Password);
        }

        [Then(@"I should see the username with hello")]
        public void ThenIShouldSeeTheUsernameWithHello()
        {
            if (CurrentPage.As<HomePage>().GetLoggedInUser().Contains("admin"))
                System.Console.WriteLine("Sucess login");
            else
                System.Console.WriteLine("Unsucessful login");
        }


        [Then(@"I click logout")]
        public void ThenIClickLogout()
        {
            CurrentPage.As<HomePage>().ClickLogOff();
        }



    }
}
