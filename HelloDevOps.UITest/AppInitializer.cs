using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace HelloDevOps.UITest
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp
                    .Android
                    .ApkFile("Binaries/com.companyname.HelloDevOps.apk")
                    .StartApp();
            }

            return ConfigureApp.iOS.StartApp();
        }
    }
}