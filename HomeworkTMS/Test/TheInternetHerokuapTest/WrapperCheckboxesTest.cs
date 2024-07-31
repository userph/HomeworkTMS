using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


    public class WrapperCheckboxesTest:BaseTest
    {

    [SetUp]
    public void Setup()
    {

        CheckboxesPage.OpenPageByUrl(CheckboxesPage.GetHerokuappDomainURL(), CheckboxesPage.GetEndPoint());
    }

    [Test]

    public void TestCheckboxesWithWrapper() 
    {
        Thread.Sleep(1000);

       

        var uiElements = Driver.FindElements(By.CssSelector("input[type='checkbox']"));
        var checkbox = new Checkbox(Driver, uiElements);


        checkbox.CheckboxStatusByIndex("IsUnchecked", 0);
        checkbox.ClickByIndex(0);
        checkbox.CheckboxStatusByIndex("IsСhecked", 0);
        Thread.Sleep(3000);

    }



}

