using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter_Test.AppFunctions
{
    public  interface HasItem
    {
        bool HasItem(string item);
        bool HasItemId(string id);
    }
}
