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


        AutorizationPage.Autorization();



        try

        {


            SubscriptionPage.ErrorModalWindow();


            SubscriptionPage.PressConfirmationButton();


            ProjectsOverviewPage.OpenPageByUrl(ProjectsOverviewPage.GetQacTestRailURL(), ProjectsOverviewPage.GetEndPoint());

            ProjectsOverviewPage.PressAddProjectButton();



        }

        catch (NoSuchElementException)

        {
            DashboardPage.PressAddProjectButton();

        }






    }




    [Test]

    public void AddProject()

    {
        
        WrapperAddProjectPage.InputName();
        WrapperAddProjectPage.InputAnnouncement();
        WrapperAddProjectPage.SelectUseRadioButton();
   
        WrapperAddProjectPage.ShowAnnouncementCheckboxIsUnchecked();
        WrapperAddProjectPage.SelectShowAnnouncementCheckbox();
        WrapperAddProjectPage.ShowAnnouncementCheckboxIsChecked();
        WrapperAddProjectPage.SelectAccessTab();
        WrapperAddProjectPage.SelectDefaultAccess();
        WrapperAddProjectPage.SelectDefectsTab();
        WrapperAddProjectPage.InputDefectViewUrl();
        WrapperAddProjectPage.InputDefectAddUrl();

        WrapperAddProjectPage.SelectFromDefectDropdownList();


        WrapperAddProjectPage.SelectReferencesTab();
        WrapperAddProjectPage.InputReferenceViewUrl();
        WrapperAddProjectPage.InputReferenceAddUrl();
        WrapperAddProjectPage.SelectFromReferenceDropdownList();

      WrapperAddProjectPage.SelectUserVariables();
       
       
        WrapperAddProjectPage.PressAddUserButton();
       
       WrapperAddProjectPage.InputUserLabel();

     
      WrapperAddProjectPage.InputUserDescription();
        
      WrapperAddProjectPage.InputUserSystemName();
        WrapperAddProjectPage.SelectUserType();

        WrapperAddProjectPage.InputUserFallback();
        WrapperAddProjectPage.AddUser();
        WrapperAddProjectPage.AddProject();
     Thread.Sleep(3000);
     






    }




}

