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



        //    AutorizationPage.Load();


        UserStep.Autorization();


        SubscriptionPage.ErrorModalWindow();


        SubscriptionPage.PressConfirmationButton();


        ProjectsOverviewPage.OpenPageByUrl(ProjectsOverviewPage.GetQacTestRailURL(), ProjectsOverviewPage.GetEndPoint());








    }




    [Test, Order(0)]

    public void AddProject()

    {


      ProjectsOverviewPage.PressAddProjectButton();

        AddProjectPage.InputName();
        AddProjectPage.InputAnnouncement();
        AddProjectPage.SelectUseRadioButton();
   
       AddProjectPage.ShowAnnouncementCheckboxIsUnchecked();
        AddProjectPage.SelectShowAnnouncementCheckbox();
       AddProjectPage.ShowAnnouncementCheckboxIsChecked();
        AddProjectPage.SelectAccessTab();
        AddProjectPage.SelectDefaultAccess();
       AddProjectPage.SelectDefectsTab();
        AddProjectPage.InputDefectViewUrl();
        AddProjectPage.InputDefectAddUrl();

        AddProjectPage.SelectFromDefectDropdownList();


        AddProjectPage.SelectReferencesTab();
        AddProjectPage.InputReferenceViewUrl();
        AddProjectPage.InputReferenceAddUrl();
       AddProjectPage.SelectFromReferenceDropdownList();

      AddProjectPage.SelectUserVariables();
       
       
       AddProjectPage.PressAddUserButton();
        AddProjectPage.InputUserLabel();

     
      AddProjectPage.InputUserDescription();
        
      AddProjectPage.InputUserSystemName();
       AddProjectPage.SelectUserType();

        AddProjectPage.InputUserFallback();
        AddProjectPage.AddUser();
        AddProjectPage.AddProject();
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

