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
public class AddProjectTest: BaseTest
{

    [SetUp]
    public void Setup()
    {


        AutorizationPage.OpenPageByUrl(AutorizationPage.GetQacTestRailURL(), AutorizationPage.GetEndPoint());
        
        
      
        AutorizationPage.InputLogin(AutorizationPage.GetQacTestRailUsername());


   
      AutorizationPage.InputPassword(AutorizationPage.GetQacTestRailPassword());
      AutorizationPage.PressLoginButton();



        
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


        

         ComponentProcessing.SendKeyToFieldWithTimeStamp(AddProjectPage.GetNameFieldBy(), 
              ContentConfigurator.ReadConfiguration().Name);

        
       ComponentProcessing.SendKeyToField(AddProjectPage.GetAnnouncementFieldBy(), 
          ContentConfigurator.ReadConfiguration().Announcement);
       ComponentProcessing.SelectCheckbox(ContentConfigurator.ReadConfiguration().ShownTheAnnouncement,
           AddProjectPage.GetAnnouncementCheckboxBy());
       ComponentProcessing.SelectCheckbox(ContentConfigurator.ReadConfiguration().EnableTestCaseApprovals,
           AddProjectPage.GetEnableTestCheckboxBy());

       AddProjectPage.SelectTab("Access");


       ComponentProcessing.SelectFromDropdownList(AddProjectPage.GetDefaultAccessDropDownListBy(), 
           ContentConfigurator.ReadConfiguration().DefaultAccess);

      AddProjectPage.SelectTab("Defects");

       ComponentProcessing.SendKeyToField(AddProjectPage.GetDefectViewUrlBy(),
   ContentConfigurator.ReadConfiguration().DefectViewUrl);

       ComponentProcessing.SendKeyToField(AddProjectPage.GetDefectAddUrlBy(),
   ContentConfigurator.ReadConfiguration().DefectAddUrl);

       AddProjectPage.SelectFromDefectDropdownList(AddProjectPage.GetDefectPluginDropDownListBy(), 
           ContentConfigurator.ReadConfiguration().DefectPlugin);


      AddProjectPage.SelectTab("References");

       ComponentProcessing.SendKeyToField(AddProjectPage.GetReferenceViewUrlBy(),
   ContentConfigurator.ReadConfiguration().ReferenceViewUrl);

       ComponentProcessing.SendKeyToField(AddProjectPage.GetReferenceAddUrlBy(),
   ContentConfigurator.ReadConfiguration().ReferenceAddUrl);

      AddProjectPage.SelectFromReferenceDropdownList(AddProjectPage.GetReferencePluginDropDownListBy(), 
          ContentConfigurator.ReadConfiguration().ReferencePlugin);


       
       AddProjectPage.SelectTab("User Variables");
       ComponentProcessing.PressButton(AddProjectPage.GetUserVariableButtonBy());


       ComponentProcessing.SendKeyToField(AddProjectPage.GetUserFieldLabelBy(),
         ContentConfigurator.ReadConfiguration().Label);
       ComponentProcessing.SendKeyToField(AddProjectPage.GetUserFieldDescriptionBy(),
   ContentConfigurator.ReadConfiguration().Description);
       ComponentProcessing.SendKeyToField(AddProjectPage.GetUserFieldNameBy(),
   ContentConfigurator.ReadConfiguration().SystemName);
       ComponentProcessing.SelectFromDropdownList(AddProjectPage.GetUserFieldTypeBy(), ContentConfigurator.ReadConfiguration().Type);
       ComponentProcessing.SendKeyToField(AddProjectPage.GetUserFieldFallbackBy(),
   ContentConfigurator.ReadConfiguration().Fallback);

       ComponentProcessing.PressButton(AddProjectPage.GetConfigureVariableConfirmationBy());
       Thread.Sleep(3000);
       ComponentProcessing.PressButton(AddProjectPage.GetAddEditProjectAddButtonBy());

       Thread.Sleep(10000);



      


    }




}

