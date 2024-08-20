using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using static System.Net.Mime.MediaTypeNames;

[TestFixture]
public class WrapperAddProjectTest : BaseTest
{

    [SetUp]
    public void Setup()
    {




      NavigationStep.NavigateToAutorizationPage();




        UserModel admin = new UserModel()
        {
            UserName = AutorizationPage.GetQacTestRailUsername(),
            Password = AutorizationPage.GetQacTestRailPassword()


        };



        UserStep.Autorization(admin);

        SubscriptionPage.ErrorModalWindow();


        SubscriptionPage.PressConfirmationButton();


        ProjectsOverviewPage.OpenPageByUrl(ProjectsOverviewPage.GetQacTestRailURL(), ProjectsOverviewPage.GetEndPoint());








    }




    [Test, Order(0)]

    public void AddProject()

    {


        ProjectsOverviewPage.PressAddProjectButton();
        UserStep.InputProjectData();
        ProjectsOverviewPage.CheckProjectAddition();

  
    }


   
    [Test, Order(1)]

    public void DeleteProject()

    {
        ProjectsOverviewPage.PressDeleteProjectButton();
        ProjectsOverviewPage.SelectDeleteCheckbox();
        ProjectsOverviewPage.SelectConfirmationDeleteOkButton();
        ProjectsOverviewPage.CheckProjectDeleted();
       
    }



}

