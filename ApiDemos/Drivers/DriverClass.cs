using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDemos.Drivers
{
    public class DriverClass
    {
        public static IWebDriver driver;
        public static void driverInitializer()
        {

            var appiumOptions = new AppiumOptions();
            appiumOptions.AddAdditionalCapability("platfom", "Android");
            appiumOptions.AddAdditionalCapability("deviceName", "Samsung Galaxy S20 Ultra LTE");
            appiumOptions.AddAdditionalCapability("Version", "13");
            appiumOptions.AddAdditionalCapability("udid", "R5CN317NG7W");
            appiumOptions.AddAdditionalCapability("app", "C:\\Users\\iray\\Downloads\\ApiDemosApk\\ApiDemos-debug.apk");
            appiumOptions.AddAdditionalCapability("Appium Server Address", "127.0.0.1:4723");
            appiumOptions.AddAdditionalCapability("ud id", "R5CN317NG7W");

            driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), appiumOptions);

        }
    }
}
