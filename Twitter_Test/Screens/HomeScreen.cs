using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace Twitter_Test.Screens
{
    public class HomeScreen
    {
        IApp iapp;
        Platform platform;
        public string fullTweet;

        public HomeScreen(IApp iapp)
        {
            this.iapp = iapp;
        }

        public IApp sendTweet(string message)
        {
            if (platform == Platform.Android)
            {
                iapp.WaitForElement(c => c.Id("button2"), "Could not find item button2", new TimeSpan(0, 0, 5));
                iapp.Tap(c => c.Id("button2"));
                fullTweet = message + NumberManager.getNewNum().ToString();
                iapp.Tap(c => c.Id("composer_write"));
                iapp.EnterText(c => c.Id("tweet_box"), fullTweet);
                iapp.Tap(c => c.Id("composer_post").Text("Tweet"));
                return iapp;

            } else
            {

            }
                return iapp;
        }

        public bool hasTweet(string tweet)
        {
            iapp.Tap(c => c.Id("home"));
            Thread.Sleep(2000);
            AppResult[] appr = iapp.Query(c => c.Id("row").Index(0).Marked("cgunqa @qachrisgun. " + tweet + ". . happening now. ."));
            if (appr.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
