using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter_Test
{
    public interface ITasks
    {
        ITasks login();
        ITasks tapLogin();
        ITasks tweet(string message);
        ITasks tweetWithImage(string message,string imgpath);

        ITasks logOut();
        ITasks tapDontAllow();
        bool hasItem(string item);
        bool hasID(string buttonName);
        bool hasTweet(string tweet);
    }
}
