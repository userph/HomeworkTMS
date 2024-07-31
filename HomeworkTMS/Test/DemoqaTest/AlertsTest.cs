using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class AlertsTest: BaseTest
    {


    [SetUp]
    public void Setup()
    {

        CheckboxesPage.OpenPageByUrl(AlertsPage.GetDemoqaDomainURL(), AlertsPage.GetEndPoint());
    }

    [Test]
    public void AlertTest()
    {

        AlertsPage.AlertButtonClick();
       
        AllertsHelper.AlertAction("Accept");

    }


    

    [Test]
    public void TimerAlertTest()
    {

        AlertsPage.TimerAlertButtonClick();
        WaitsHelper.ExplicitlyWaitAllert(10);
        AllertsHelper.AlertAction("Accept");

    }


    

    [Test]
    public void ConfirmTest()
    {

        AlertsPage.ConfirmButtonClick();

        AllertsHelper.AlertAction("Dismiss");

        AlertsPage.CheckAlertResult("confirmResult", "Cancel");

    }


    [Test]
    public void PromptTest()
    {

        AlertsPage.PromptButtonClick();
        AllertsHelper.AlertAction("SendKeys", "Hello");
        AllertsHelper.AlertAction("Accept");
        AlertsPage.CheckAlertResult("promptResult", "Hello");

    }









}

