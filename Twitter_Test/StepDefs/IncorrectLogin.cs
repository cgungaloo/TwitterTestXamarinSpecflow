using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Twitter_Test.AppFunctions;
using Twitter_Test.platformReturn;
using Xamarin.UITest;

namespace Twitter_Test.StepDefs
{
    [Binding]
    public class IncorrectLogin
    {
        IApp iapp = BeforeAfterHook.app;
        LoginScreen login;
        HasItem hasItem;
        getHasItem getHasItem;

        [When(@"I login with an incorrect username and password")]
        public void WhenILoginWithAnIncorrectUsernameAndPassword()
        {
            login = new LoginScreen(iapp);
            login.Login();
            getHasItem = new getHasItem(iapp);
            hasItem = getHasItem.getHasItemObject();
        }

        [Then(@"an error message will come up")]
        public void ThenAnErrorMessageWillComeUp()
        {
            
            Assert.IsFalse(hasItem.HasItemId("button2"));
        }

    }
}
