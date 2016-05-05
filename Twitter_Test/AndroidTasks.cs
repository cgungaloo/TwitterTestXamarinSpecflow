using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Xamarin.UITest;
using Xamarin.UITest.Android;
using Xamarin.UITest.Queries;

namespace Twitter_Test
{
    partial class AndroidTasks : ITasks
    {
       readonly IApp app;
        public static string fullTweet;

        public AndroidTasks(IApp app)
        {
            this.app = app;
        }

        public bool hasItem(string item)
        {
            try
            {
                app.WaitForElement(c => c.Marked(item),"Could not find item", new TimeSpan(0,0,5));
                return true;
            }catch(Exception e)
            {
                return false;
            }
        }

        public ITasks login()
        {
            string username;
            string password;
            if (ScenarioContext.Current.ScenarioInfo.Title.Equals("Incorrect Login"))
            {
                username = "username";
                password = "password";
            }else
            {
                CredentialsManager.getCredentials();
                username = CredentialsManager.username;
                password = CredentialsManager.password;
            }
            app.Tap(c => c.Id("login_identifier"));
            app.Query(c => c.Id("login_identifier").Invoke("setText", string.Empty));
            app.EnterText(c => c.Id("login_identifier"), username);
            
            app.Tap(c => c.Id("login_password"));

            app.Screenshot("Credentials");
            app.EnterText(c => c.Id("login_password"), password);
            app.Tap(c => c.Id("login_login").Text("Log in"));
            app.Screenshot("Post_Login");
            return this;
        }

        public ITasks tapLogin()
        {
            app.Tap(c => c.Id("log_in").Text("Log in"));
            return this;
        }

        public ITasks tweet(string message)
        {

            fullTweet = message + NumberManager.getNewNum().ToString();
            app.Tap(c => c.Id("composer_write"));
            app.EnterText(c=>c.Id("tweet_box"),fullTweet);
            app.Tap(c => c.Id("composer_post").Text("Tweet"));
            return this;
        }

        public ITasks tweetWithImage(string message, string imgpath)
        {
            throw new NotImplementedException();
        }
    }
}
