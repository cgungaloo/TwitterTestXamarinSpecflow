using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Twitter_Test.StepDefs
{
    [Binding]
    class IncorrectLogin
    {
        ITasks app = BeforeAfterHook.task;


        [When(@"I login with an incorrect username and password")]
        public void WhenILoginWithAnIncorrectUsernameAndPassword()
        {
            app.login();
        }

        [Then(@"an error message will come up")]
        public void ThenAnErrorMessageWillComeUp()
        {
            Assert.IsFalse(app.hasItem("DON'T ALLOW"));
        }

    }
}
