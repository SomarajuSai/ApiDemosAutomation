using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using TechTalk.SpecFlow;
using System;
using ApiDemos.Drivers;
using OpenQA.Selenium;

namespace YourProjectNamespace.Hooks
{
    [Binding]
    public class Hooks : DriverClass
    {


        [BeforeScenario]
        public static void BeforeScenario()

        {
             DriverClass.driverInitializer();

        }

      
    }
}
