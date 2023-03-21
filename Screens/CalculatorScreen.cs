using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumCalculatorTestsPOM.Pages
{
    public class CalculatorScreen
    {
        private WindowsDriver<WindowsElement> driver;
        public CalculatorScreen(WindowsDriver<WindowsElement> driver)
        {
            this.driver = driver;
        }

        public WindowsElement FirstNum => driver.FindElementByAccessibilityId("textBoxFirstNum");
        public WindowsElement SecondNum => driver.FindElementByAccessibilityId("textBoxSecondNum");
        public WindowsElement ResultField => driver.FindElementByAccessibilityId("textBoxSum");
        public WindowsElement CalcButton => driver.FindElementByAccessibilityId("buttonCalc");

        public string CalculateTwoNumbers(string firstNumber, string secondNumber)
        {
            FirstNum.Clear();
            SecondNum.Clear();
            FirstNum.SendKeys(firstNumber);
            SecondNum.SendKeys(secondNumber);
            CalcButton.Click();

            return ResultField.Text;
        }
    }
}
