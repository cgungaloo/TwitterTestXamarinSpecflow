using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest.Queries;

namespace Twitter_Test
{
    public partial class AndroidTasks: ITasks
    {
        //MS Naming conventions
        public static string fullTweetImage;
        public ITasks logOut()
        {
            app.Tap(c => c.Id("overflow").Marked("More"));
            app.Tap(c => c.Text("Settings"));
            app.Tap(c => c.Text("Sign out"));
            app.Tap(c => c.Id("button1").Text("OK"));
            return this;
        }

        public ITasks tapDontAllow()
        {
            app.WaitForElement(c => c.Id("button2"), "Could not find item button2", new TimeSpan(0, 0, 5));
            app.Tap(c => c.Id("button2"));
            
            return this;
        }

        public bool hasID(string idName)
        {
            try
            {
                app.WaitForElement(c => c.Id(idName), "Could not find item " + idName, new TimeSpan(0, 0, 5));
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool hasTweet(string tweet)
        {
            app.Tap(c => c.Id("home"));
            AppResult[] appr = app.Query(c => c.Id("row").Index(0).Marked("cgunqa @qachrisgun. " + tweet + ". . happening now. ."));
            if(appr.Length > 0)
            {
                return true;
            }else
            {
                return false;
            }
        }

        public ITasks tweetImage(string tweetText)
        {

            fullTweetImage = tweetText + NumberManager.getNewNum().ToString();
            app.Tap(c => c.Id("composer_photos"));
            app.Tap(c => c.Id("gallery_image_image").Index(0));
            app.EnterText(c => c.Id("tweet_box"), fullTweetImage);
            app.Tap(c => c.Id("composer_post").Text("Tweet"));
            return this;
        }
    }
}
