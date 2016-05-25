using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using Twitter_Test;
using Twitter_Test.AppFunctions;
using Twitter_Test.platformReturn;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace Twitter_Test.StepDefs
{
    [Binding]
    public class LoginSteps
    {
        IApp iapp;
        LoginScreen login;
        HasItem hasItem;
        getHasItem getHasItem;

        [Given(@"I am on the login screen")]
        public void GivenIAmOnTheLoginScreen()
        {
            iapp = BeforeAfterHook.app;
            login = new LoginScreen(iapp);
            //app = BeforeAfterHook.task;
            //Assert.IsTrue(app.hasItem("Log in to Twitter."));
        }


        [When(@"I login with correctusername and password")]
        public void WhenILoginWithCorrectusernameAndPassword()
        {
            login.Login();
        }
        
        [Then(@"I will be on the twitter homescreen")]
        public void ThenIWillBeOnTheTwitterHomescreen()
        {
            getHasItem = new getHasItem(iapp);
            hasItem = getHasItem.getHasItemObject();
            Assert.IsTrue(hasItem.HasItemId("button2"));
            //app.tapDontAllow();
        }
    }
}
