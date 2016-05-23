using System;
using TechTalk.SpecFlow;

namespace Twitter_Test.StepDefs
{
    [Binding]
    public class ScrollUpDownSteps
    {

        ITasks app;
        [Given(@"I am on the home screen")]
        public void GivenIAmOnTheHomeScreen()
        {
            app = BeforeAfterHook.task;
            
        }
        
        [When(@"I scroll down")]
        public void WhenIScrollDown()
        {
            app.scrollDown();
        }
        
        [When(@"I scroll up")]
        public void WhenIScrollUp()
        {
            app.scrollUp();
        }
        
    }
}
