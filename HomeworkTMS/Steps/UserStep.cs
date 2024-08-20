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






    public void InputProjectData(ProjectModel projectsModel) 
    
    {
  


        _addProjectPage.Name().SendKeyWithTimeStamp(projectsModel.Name);
        _addProjectPage.Announcement().SendKey(projectsModel.Announcement);
        _addProjectPage.SelectShowAnnouncementCheckbox(projectsModel.ShownTheAnnouncement);
        _addProjectPage.UseRadioButton().SelectByIndex(projectsModel.UseIndex);
        _addProjectPage.SelectEnableTestCaseApprovals(projectsModel.EnableTestCaseApprovals);
        _addProjectPage.AccessTab().Click();
        _addProjectPage.DefaultAccess().SelectByText(projectsModel.DefaultAccess);
        _addProjectPage.DefectsTab().Click();
        _addProjectPage.DefectViewUrl().SendKey(projectsModel.DefectViewUrl);
        _addProjectPage.DefectAddUrl().SendKey(projectsModel.DefectAddUrl);
        _addProjectPage.SelectFromDefectDropdownList(projectsModel.DefectPlugin);
        _addProjectPage.ReferencesTab().Click();
        _addProjectPage.ReferenceViewUrl().SendKey(projectsModel.ReferenceViewUrl);
        _addProjectPage.ReferenceAddUrl().SendKey(projectsModel.ReferenceAddUrl);
        _addProjectPage.SelectFromReferenceDropdownList(projectsModel.DefectPlugin);
        _addProjectPage.UserVariables().Click();
        _addProjectPage.AddUserButton().Click();
        _addProjectPage.UserLabel().SendKey(projectsModel.Label);
        _addProjectPage.UserDescription().SendKey(projectsModel.Description);
        _addProjectPage.UserSystemName().SendKey(projectsModel.SystemName);
        _addProjectPage.UserType().SelectByText(projectsModel.TypeName);
        _addProjectPage.UserFallback().SendKey(projectsModel.Fallback);
        _addProjectPage.UserAcceptButton().Click();
        _addProjectPage.AddProjectButton().Click();








    }





}

