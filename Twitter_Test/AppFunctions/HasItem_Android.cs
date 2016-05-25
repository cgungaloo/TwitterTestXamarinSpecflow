using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest;

namespace Twitter_Test.AppFunctions
{
    public class HasItem_Android : HasItem
    {
        IApp app;
        public HasItem_Android(IApp app)
        {
            this.app = app;
        }
        public bool HasItem(string item)
        {
            try
            {
                app.WaitForElement(c => c.Marked(item), "Could not find item", new TimeSpan(0, 0, 7));
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool HasItemId(string id)
        {
            try
            {
                app.WaitForElement(c => c.Id(id), "Could not find item " + id, new TimeSpan(0, 0, 5));
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
