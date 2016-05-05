using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using Twitter_Test;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace Twitter_Test.StepDefs
{
    [Binding]
    public class LoginSteps
    {
        ITasks app;
        [Given(@"I am on the login screen")]
        public void GivenIAmOnTheLoginScreen()
        {
            app = BeforeAfterHook.task;
            Assert.IsTrue(app.hasItem("Log in to Twitter."));
        }


        [When(@"I login with correctusername and password")]
        public void WhenILoginWithCorrectusernameAndPassword()
        {
            app.login();   
        }
        
        [Then(@"I will be on the twitter homescreen")]
        public void ThenIWillBeOnTheTwitterHomescreen()
        {
            Assert.IsTrue(app.hasID("button2"));
            app.tapDontAllow();
        }
    }
}
