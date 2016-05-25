using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Xamarin.UITest;

namespace Twitter_Test
{
    public class LoginScreen
    {
        readonly IApp app;
        static Platform platform;
        public LoginScreen(IApp app)
        {
            this.app = app;
        }
        public void Login()
        {
            string username;
            string password;

            if (FeatureContext.Current.FeatureInfo.Title.Equals("Login"))
            {
                if (ScenarioContext.Current.ScenarioInfo.Title.Equals("Incorrect Login"))
                {
                    username = "username";
                    password = "password";
                }
                else
                {
                    CredentialsManager.getCredentials();
                    username = CredentialsManager.username;
                    password = CredentialsManager.password;
                }

            }
            else
            {
                CredentialsManager.getCredentials();
                username = CredentialsManager.username;
                password = CredentialsManager.password;
            }

            Login(username, password);
        }

        private IApp Login(string username, string password)
        {
            if (platform == Platform.Android)
            {
                app.Tap(c => c.Id("log_in").Text("Log in"));
                app.Tap(c => c.Id("login_identifier"));
                app.Query(c => c.Id("login_identifier").Invoke("setText", string.Empty));
                app.EnterText(c => c.Id("login_identifier"), username);

                app.Tap(c => c.Id("login_password"));

                app.Screenshot("Credentials");
                app.EnterText(c => c.Id("login_password"), password);
                app.Tap(c => c.Id("login_login").Text("Log in"));
                //app.Screenshot("Post_Login");
            }else
            {
                Console.WriteLine("IOS login implementation");
            }

            return app;
        }

        public bool ValidateLogin()
        {
            return false;
        }
    }
}
