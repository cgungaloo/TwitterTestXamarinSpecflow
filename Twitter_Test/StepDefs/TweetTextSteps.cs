using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Twitter_Test.StepDefs
{
    [Binding]
    public class TweetTextSteps
    {
        ITasks app;
        [When(@"I send a the tweet ""(.*)""")]
        public void WhenISendATheTweet(string tweet)
        {
            app = BeforeAfterHook.task;
            app.tweet(tweet);
        }


        [Then(@"then I should see the tweet in my profile\.")]
        public void ThenThenIShouldSeeTheTweetInMyProfile_()
        {
            Assert.IsTrue(app.hasTweet(AndroidTasks.fullTweet));
        }

    }
}
