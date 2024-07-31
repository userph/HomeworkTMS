using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class DropdownPage: BasePage
    {

        private string _endPoint = "dropdown";
        private static readonly By DropdownListBy = By.Id("dropdown");





        public DropdownPage(IWebDriver driver) : base(driver)

        {
            Driver = driver;


        }


        public IWebDriver Driver { get; set; }


        public override string GetEndPoint()

        {
            return _endPoint;
        }


        public IWebElement DropdownList() => Driver.FindElement(DropdownListBy);

        public ReadOnlyCollection<IWebElement> DropdownItems => DropdownList().FindElements(By.TagName("option"));

     





        public void SelectDropdownItem(int ItemIndex)
        {

            DropdownItems[ItemIndex].Click();

        }


    public void CheckDropdownItemSelection(int ItemIndex)

    {

        Assert.That(DropdownItems[ItemIndex].Selected, Is.True);
    }




    }

