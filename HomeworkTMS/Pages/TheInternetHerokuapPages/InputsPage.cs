using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class InputsPage: BasePage
    {

        private string _endPoint = "inputs";
        private static readonly By InputFieldBy = By.TagName("input");





        public InputsPage(IWebDriver driver) : base(driver)

        {
            Driver = driver;


        }

        public IWebDriver Driver { get; set; }


        public override string GetEndPoint()

        {
            return _endPoint;
        }


        public IWebElement InputField() => Driver.FindElement(InputFieldBy);

        public void EnteringValue(string value) => InputField().SendKeys(value);

        public void ValueChecking(string expectedValue)

        {
            string actualValue = InputField().GetAttribute("value");
            Assert.That(expectedValue, Is.EqualTo(actualValue));

        }

        public void ValueIncreasing() => InputField().SendKeys(Keys.Up);
        public void ValueDecrease() => InputField().SendKeys(Keys.Down);






    }

