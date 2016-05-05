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
        public ITasks logOut()
        {
            app.Tap(c => c.Id("overflow").Marked("More"));
            app.Tap(c => c.Text("Settings"));
            app.Tap(c => c.Text("Sign out"));
            app.Tap(c => c.Id("button1").Text("OK"));
            //app.Repl();
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
    }
}
