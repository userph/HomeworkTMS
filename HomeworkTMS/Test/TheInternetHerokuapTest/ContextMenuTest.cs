using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ContextMenuTest : BaseTest
{


    [SetUp]
    public void Setup()
    {

        ContextMenuPage.OpenPageByUrl(ContextMenuPage.GetHerokuappDomainURL(), ContextMenuPage.GetEndPoint());
    }


    [Test]
    [Category("Common")]
    public void Test()

    {

        ActionsHelper.MoveToElement(ContextMenuPage.FindHotspot());
        ActionsHelper.ContextClick(ContextMenuPage.FindHotspot());
        AllertsHelper.CompareAllertText(ContextMenuPage.GetAllertText());
        AllertsHelper.AcceptAlert();


    }





}

