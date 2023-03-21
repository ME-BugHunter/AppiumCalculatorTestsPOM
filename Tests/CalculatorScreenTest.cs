using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Appium;
using NUnit.Framework;
using AppiumCalculatorTestsPOM.Pages;

namespace AppiumCalculatorTestsPOM.Tests
{
    public class CalculatorScreenTest : BaseTest
    {
        private CalculatorScreen screen;

        [OneTimeSetUp]
        public void Setup()
        {
            this.screen = new CalculatorScreen(driver);
        }

        
        [Test]
        public void Test_Calculate_TwoPositiveNumbers()
        {
            var actualResult = screen.CalculateTwoNumbers("5", "10");

            Assert.That(actualResult, Is.EqualTo("15"));
        }
    }
}