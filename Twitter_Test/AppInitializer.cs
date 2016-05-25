using System;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace Twitter_Test
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp
                    .Android
                    //Enter path tpo APK
                    .ApkFile("C:\\Users\\Chris Gungaloo\\Documents\\Visual Studio 2015\\Projects\\Twitter_Test\\Twitter_Test\\Assets\\Android\\Twitter_v5.106.0_apkpure.com.apk")
                    .EnableLocalScreenshots()
                    .StartApp();
            }
            else
            {

                return ConfigureApp
                    .iOS
                    .AppBundle("C:\\Users\\Chris Gungaloo\\Documents\\Visual Studio 2015\\Projects\\Twitter_Test\\Twitter_Test\\Assets\\Android\\Twitter_v5.106.0_apkpure.com.apk")
                    .EnableLocalScreenshots()
                    .StartApp();
 
            }
        }
    }
}

