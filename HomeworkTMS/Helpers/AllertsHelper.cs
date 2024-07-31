using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;



public class AllertsHelper
{

    private IWebDriver _driver { get; set; }


    public AllertsHelper(IWebDriver driver)
    {
        _driver = driver;
    }




    public IAlert Alert() => _driver.SwitchTo().Alert();

    public string GetAlertText() => Alert().Text;

    public void AcceptAlert() => Alert().Accept();


    public void CompareAllertText(string text) => Assert.That(GetAlertText(), Is.EqualTo(text));




       public void AlertAction(string action, string text = null)

    {

        if (action == "Accept")

        {
            Alert().Accept();

        }

        else if (action == "Dismiss")

        {

            Alert().Dismiss();

        }

        else if (action == "SendKeys")

        {

            Alert().SendKeys(text);

        }

        else 
        { 
            
            throw new Exception(); 
        
        }






    }


   







}

