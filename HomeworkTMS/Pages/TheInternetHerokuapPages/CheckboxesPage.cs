using Allure.NUnit.Attributes;
using OpenQA.Selenium;
using System.Security.Cryptography.X509Certificates;
using NUnit.Framework;
using System.Collections.ObjectModel;


public class CheckboxesPage : BasePage
{

    private string _endPoint = "checkboxes";




    private static readonly By CheckboxBy = By.CssSelector("[type = 'checkbox']");


    public CheckboxesPage(IWebDriver driver) : base(driver)

    {
        Driver = driver;


    }


    public IWebDriver Driver { get; set; }


    public override string GetEndPoint()

    {
        return _endPoint;
    }


    public ReadOnlyCollection<IWebElement> GetCheckboxElements()
    {

        return Driver.FindElements(CheckboxBy);

    }






    public void CheckSelection (string selectionStatusValue, int checkboxIndex)

           
    {
        var checkboxElements = GetCheckboxElements();

        if (selectionStatusValue == "IsСhecked")

        {
            Assert.That(checkboxElements[checkboxIndex].Selected, Is.True);

        }


        else if (selectionStatusValue == "IsUnchecked")
        {
            Assert.That(checkboxElements[checkboxIndex].Selected, Is.False);
        }

        else
        {
            throw new ArgumentException($"Invalid boolean value: {selectionStatusValue}");
        }



    }


    public void SelectCheckbox(int checkboxIndex)

    {

        var checkboxElements = GetCheckboxElements();
        checkboxElements[checkboxIndex].Click();

    }








}

