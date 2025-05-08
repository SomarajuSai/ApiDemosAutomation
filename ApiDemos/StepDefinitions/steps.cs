using ApiDemos.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourProjectNamespace.Hooks;

namespace ApiDemos.StepDefinitions
{
    [Binding]
    public class steps : Hooks
    {
      
        [Given(@"Open the app")]
        public static void GivenOpenTheApp()
        {
            Console.WriteLine("App launched");
        }

        [When(@"Click on App")]
        public static void WhenClickOnApp()
        {
           driver.FindElement(By.XPath("//android.widget.TextView[@content-desc=\"App\"]")).Click();
        }

        [When(@"Click on Alert Dialogs")]
        public static void WhenClickOnAlertDialogs()
        {
            driver.FindElement(By.XPath("//android.widget.TextView[@content-desc=\"Alert Dialogs\"]")).Click();
        }

        [When(@"Click on '([^']*)'")]
        public void WhenClickOn(string message)
        {
            driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"OK Cancel dialog with a message\"]")).Click();
            try
            {
                var popupElement = driver.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"android:id/alertTitle\"]"));

                string popupText = popupElement.Text;

                Console.WriteLine($"Popup Message: {popupText}");
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Popup message not found.");
            }

        }

        [Then(@"Click on Ok Button")]
        public void ThenClickOnOkButton()
        {
            driver.FindElement(By.XPath("//android.widget.Button[@resource-id=\"android:id/button1\"]")).Click(); 
        }



    }

}
