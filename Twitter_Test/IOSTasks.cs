using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest;

namespace Twitter_Test
{
    partial class IOSTasks : ITasks
    {
        private IApp app;
        public IOSTasks(IApp app)
        {
            this.app = app;
        }
        public bool hasItem(string item)
        {
            throw new NotImplementedException();
        }

        public void login()
        {
            throw new NotImplementedException();
        }

        public ITasks tapLogin()
        {
            throw new NotImplementedException();
        }

        public void tweet(string message)
        {
            throw new NotImplementedException();
        }

        public void tweetWithImage(string message, string imgpath)
        {
            throw new NotImplementedException();
        }

        ITasks ITasks.login()
        {
            throw new NotImplementedException();
        }

        ITasks ITasks.tweet(string message)
        {
            throw new NotImplementedException();
        }

        ITasks ITasks.tweetWithImage(string message, string imgpath)
        {
            throw new NotImplementedException();
        }
    }
}
