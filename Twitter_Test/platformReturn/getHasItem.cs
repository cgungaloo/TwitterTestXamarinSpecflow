using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitter_Test.AppFunctions;
using Xamarin.UITest;

namespace Twitter_Test.platformReturn
{
    public class getHasItem
    {
        Platform platform;
        IApp iapp;
        public getHasItem(IApp iapp)
        {
            this.iapp = iapp;
        }

        public HasItem getHasItemObject()
        {
            if(platform == Platform.Android)
            {
                return new HasItem_Android(iapp);
            }else
            {
                return new HasItem_IOS(iapp);
            }
        }
    }
}
