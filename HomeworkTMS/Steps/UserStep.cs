using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class UserStep: BaseStep
    {

    private AutorizationPage _autorizationPage;
    private AddProjectPage _addProjectPage;


    public UserStep(IWebDriver driver): base(driver)
    
    { 
    
    _autorizationPage = new AutorizationPage(driver);
    _addProjectPage = new AddProjectPage(driver);
    
    }







    public void Autorization(UserModel userModel)

    {

        _autorizationPage.FindInputLoginField().SendKeys(userModel.UserName);
        _autorizationPage.FindInputPasswordField().SendKeys(userModel.Password);
        _autorizationPage.FindLoginButton().Click();
    }






    public void InputProjectData() 
    
    {

        /*
            public string? ShownTheAnnouncement { get; set; }
            public string? EnableTestCaseApprovals { get; set; }

        */

   


        _addProjectPage.Name().SendKeyWithTimeStamp(ContentConfigurator.ReadConfiguration().Name);
        _addProjectPage.Announcement().SendKey(ContentConfigurator.ReadConfiguration().Announcement);
        _addProjectPage.SelectShowAnnouncementCheckbox(ContentConfigurator.ReadConfiguration().ShownTheAnnouncement);
        _addProjectPage.UseRadioButton().SelectByIndex(ContentConfigurator.ReadConfiguration().UseIndex);
        _addProjectPage.SelectEnableTestCaseApprovals(ContentConfigurator.ReadConfiguration().EnableTestCaseApprovals);
        _addProjectPage.AccessTab().Click();
        _addProjectPage.DefaultAccess().SelectByText(ContentConfigurator.ReadConfiguration().DefaultAccess);
        _addProjectPage.DefectsTab().Click();
        _addProjectPage.DefectViewUrl().SendKey(ContentConfigurator.ReadConfiguration().DefectViewUrl);
        _addProjectPage.DefectAddUrl().SendKey(ContentConfigurator.ReadConfiguration().DefectAddUrl);
        _addProjectPage.SelectFromDefectDropdownList(ContentConfigurator.ReadConfiguration().DefectPlugin);
        _addProjectPage.ReferencesTab().Click();
        _addProjectPage.ReferenceViewUrl().SendKey(ContentConfigurator.ReadConfiguration().ReferenceViewUrl);
        _addProjectPage.ReferenceAddUrl().SendKey(ContentConfigurator.ReadConfiguration().ReferenceAddUrl);
        _addProjectPage.SelectFromReferenceDropdownList(ContentConfigurator.ReadConfiguration().DefectPlugin);
        _addProjectPage.UserVariables().Click();
        _addProjectPage.AddUserButton().Click();
        _addProjectPage.UserLabel().SendKey(ContentConfigurator.ReadConfiguration().Label);
        _addProjectPage.UserDescription().SendKey(ContentConfigurator.ReadConfiguration().Description);
        _addProjectPage.UserSystemName().SendKey(ContentConfigurator.ReadConfiguration().SystemName);
        _addProjectPage.UserType().SelectByText(ContentConfigurator.ReadConfiguration().Type);
        _addProjectPage.UserFallback().SendKey(ContentConfigurator.ReadConfiguration().Fallback);
        _addProjectPage.UserAcceptButton().Click();
        _addProjectPage.AddProjectButton().Click();




        /*



        */



    }





}

