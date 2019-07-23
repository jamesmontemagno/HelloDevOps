using System;
using Xamarin.UITest;
using Xamarin.UITest.Configuration;
using Xamarin.UITest.Queries;

namespace HelloDevOps.UITest
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
#if DEBUG
            
#endif
            if (platform == Platform.Android)
            {
                return ConfigureApp
                    .Android        
                    .ApkFile("C:/Users/jamont/source/repos/HelloDevOps/Binaries/com.companyname.HelloDevOps.apk")
                    .StartApp(AppDataMode.DoNotClear);
            }

            return ConfigureApp.iOS.StartApp();
        }
    }
}