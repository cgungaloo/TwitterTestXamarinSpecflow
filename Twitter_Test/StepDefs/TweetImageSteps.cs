using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Twitter_Test.StepDefs
{
    [Binding]
    public class TweetImageSteps
    {
        ITasks app;

        [Given(@"I have an image on my phone")]
        public void GivenIHaveAnImageOnMyPhone()
        {
            app = BeforeAfterHook.task;
        }


        [When(@"I tweet the image with text ""(.*)""")]
        public void WhenITweetTheImageWithText(string tweetText)
        {
            app.tweetImage(tweetText);
        }
        
        [Then(@"I should see the image tweeted in my profile")]
        public void ThenIShouldSeeTheImageTweetedInMyProfile()
        {
            Assert.IsTrue(app.hasTweet(AndroidTasks.fullTweetImage));
        }
    }
}
