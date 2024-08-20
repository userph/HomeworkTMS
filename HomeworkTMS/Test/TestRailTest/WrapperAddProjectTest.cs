using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HomeworkTMS.Models;
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



        ProjectModel project = new ProjectModel()

        {


            Name = ContentConfigurator.ReadConfiguration().Name,
            Announcement = ContentConfigurator.ReadConfiguration().Announcement,

            UseIndex = ContentConfigurator.ReadConfiguration().UseIndex,

            ShownTheAnnouncement = ContentConfigurator.ReadConfiguration().ShownTheAnnouncement,

            EnableTestCaseApprovals = ContentConfigurator.ReadConfiguration().EnableTestCaseApprovals,

            DefaultAccess = ContentConfigurator.ReadConfiguration().DefaultAccess,
            DefectViewUrl = ContentConfigurator.ReadConfiguration().DefectViewUrl,

            DefectAddUrl = ContentConfigurator.ReadConfiguration().DefectAddUrl,
            DefectPlugin = ContentConfigurator.ReadConfiguration().DefectPlugin,
            ReferenceViewUrl = ContentConfigurator.ReadConfiguration().ReferenceViewUrl,

                ReferenceAddUrl = ContentConfigurator.ReadConfiguration().ReferenceAddUrl,
            ReferencePlugin = ContentConfigurator.ReadConfiguration().DefectPlugin,

            Label = ContentConfigurator.ReadConfiguration().Label,

            Description = ContentConfigurator.ReadConfiguration().Description,

            SystemName = ContentConfigurator.ReadConfiguration().SystemName,
            TypeName = ContentConfigurator.ReadConfiguration().TypeName,

            Fallback = ContentConfigurator.ReadConfiguration().Fallback



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

