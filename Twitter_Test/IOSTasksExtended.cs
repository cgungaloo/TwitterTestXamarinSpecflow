using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter_Test
{
    partial class IOSTasks : ITasks
    {
        public ITasks logOut()
        {
            return this;
        }

        public ITasks tapDontAllow()
        {
            return this;
        }

        public bool hasID(string idName)
        {
            return false;
        }

        public bool hasTweet(string tweet)
        {
            return false;
        }
    }
}
