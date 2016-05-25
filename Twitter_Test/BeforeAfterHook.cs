using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Xamarin.UITest;

namespace Twitter_Test
{
    [Binding]
    public sealed class BeforeAfterHook
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        public static ITasks task;
        static Platform platform;
        LoginScreen login;
        public static IApp app;

        [BeforeScenario("loginScreen")]
        public void BeforeScenario()
        {
            app = AppInitializer.StartApp(platform);
            LoginScreen login = new LoginScreen(app);
            login.Login();
            
        }

        [BeforeScenario("login")]
        public void BeforeScenarioLogin()
        {
            //task = AppInitializer.StartApp(platform);
            //task.tapLogin();
            //task.login();
            //task.tapDontAllow();
        }

        [AfterScenario("logout")]
        public void AfterScenario()
        {
            task.logOut();
        }

        [BeforeFeature("BeforeTweet")]
        public static void BeforeTweet()
        {
            //task = AppInitializer.StartApp(platform);
            //task.tapLogin();

            //task.login();
            //task.tapDontAllow();
        }

        [AfterFeature("AfterTweet")]
        public static void AfterTweet()
        {
            task.logOut();
        } 
    }
}
