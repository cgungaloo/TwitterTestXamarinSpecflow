using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter_Test
{
    public static class CredentialsManager
    {
        internal static string password;
        internal static string username;

        public static void getCredentials()
        {
            string path = "C:\\Users\\Chris Gungaloo\\Documents\\TwitterLoginCredentials.json";
            JObject jo = JObject.Parse(File.ReadAllText(path));

            username =jo.GetValue("username").ToString();
            password = jo.GetValue("password").ToString();
        }
    }
}
