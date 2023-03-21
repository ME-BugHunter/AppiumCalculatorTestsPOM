using AppiumCalculatorTestsPOM.Pages;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AppiumCalculatorTestsPOM.Tests
{
    public class BaseTest
    {
        private const string appiumServer = "http://127.0.0.1:4723/wd/hub";
        private const string appLocation = @"C:\Users\Lenovo\SummatorDesktopApp.exe";
        protected WindowsDriver<WindowsElement> driver;
        private AppiumOptions appiumOptions;
       

        [OneTimeSetUp]
        public void Setup()
        {
            this.appiumOptions = new AppiumOptions();
            appiumOptions.AddAdditionalCapability("app", appLocation);
            appiumOptions.AddAdditionalCapability("PlatformName", "Windows");
            this.driver = new WindowsDriver<WindowsElement>(new Uri(appiumServer), appiumOptions);
        }
        
        [OneTimeTearDown]
        public void CloseApp()
        {
            driver.Quit();
        }
    }
}
