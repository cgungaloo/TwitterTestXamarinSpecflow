using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using Twitter_Test.Screens;
using Xamarin.UITest;

namespace Twitter_Test.StepDefs
{
    [Binding]
    public class TweetTextSteps
    {
        IApp iapp;
        HomeScreen homescreen;
        [When(@"I send a the tweet ""(.*)""")]
        public void WhenISendATheTweet(string tweet)
        {
            iapp = BeforeAfterHook.app;
            homescreen = new HomeScreen(iapp);
            homescreen.sendTweet(tweet);
        }


        [Then(@"then I should see the tweet in my profile\.")]
        public void ThenThenIShouldSeeTheTweetInMyProfile_()
        {
            Assert.IsTrue(homescreen.hasTweet(homescreen.fullTweet));
        }

    }
}
