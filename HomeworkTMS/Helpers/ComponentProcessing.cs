using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class ComponentProcessing
    {

    private readonly IWebDriver _driver;
    private readonly DateTime _currentDateTime;

    public ComponentProcessing(IWebDriver driver)
    {
        _driver = driver;
        _currentDateTime = DateTime.Now;

    }




    public void SendKeyToField(By FieldBy, string Key)

    {
        IWebElement Field = _driver.FindElement(FieldBy);
        
        Field.SendKeys(Key);
    }


    public void SendKeyToFieldWithTimeStamp(By FieldBy, string Key)

    {
        IWebElement Field = _driver.FindElement(FieldBy);

        Field.SendKeys(Key + " (timestamp:" + _currentDateTime + ")");
    }





    public void SelectFromDropdownList(By GetDropDownListBy, string Text)

    {

        IWebElement DropDownList = _driver.FindElement(GetDropDownListBy);

        SelectElement dropdown = new SelectElement(DropDownList);

        dropdown.SelectByText(Text);

    }

    public void SelectCheckbox(string Status, By CheckboxBy)

    {

        IWebElement Checkbox() => _driver.FindElement(CheckboxBy);


        if (Status == "yes")
        {
            Checkbox().Click();
        }

        else if (Status == "no")
        {
        }

        else
        {
            throw new Exception("Неверное значение атрибута в addprojectdata.json");
        }
    }


    public void PressButton(By ButtonBy)

    {
        IWebElement Button() => _driver.FindElement(ButtonBy);

        
        Button().Click();

    }





}

