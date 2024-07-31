using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class AddProjectPage : BasePage
{

    private string _endPoint = "index.php?/admin/projects/add/1";







    public AddProjectPage(IWebDriver driver) : base(driver)

    {
        Driver = driver;


    }


    public IWebDriver Driver { get; set; }


    public override string GetEndPoint()

    {
        return _endPoint;
    }




    public By GetNameFieldBy() =>
        By.XPath("//input[@data-testid='addProjectNameInput']");

    public By GetAnnouncementFieldBy() =>
        By.XPath("//textarea[@data-testid='addEditProjectAnnouncement']");

    public By GetAnnouncementCheckboxBy() =>
        By.XPath("//input[@data-testid='addEditProjectShowAnnouncement']");

    public By GetEnableTestCheckboxBy() =>
    By.XPath("//input[@data-testid='addEditProjectCaseStatusesEnabled']");

    public By GetDefaultAccessDropDownListBy() =>
        By.XPath("//select[@data-testid='addEditProjectAccessTabAccess']");

    public By GetDefectViewUrlBy() => By.Id("defect_id_url");

    public By GetDefectAddUrlBy() => By.Id("defect_add_url");

    public By GetDefectPluginBy() => By.XPath("//div[@id='defect_plugin_chzn' and @class='chzn-container chzn-container-single']");


    public By GetReferenceViewUrlBy() => By.Id("reference_id_url");

    public By GetReferenceAddUrlBy() => By.Id("reference_add_url");

    public By GetReferencePluginBy() => By.XPath("//div[@id='reference_plugin_chzn' and @class='chzn-container chzn-container-single']");

    public By GetUserVariableButtonBy() => By.XPath("//a[contains(., 'Add User Variable')]");

    public By GetUserFieldLabelBy() => By.Id("userFieldLabel");
    public By GetUserFieldDescriptionBy() => By.Id("userFieldDesc");
    public By GetUserFieldNameBy() => By.Id("userFieldName");
    public By GetUserFieldTypeBy() => By.Id("userFieldType");
    public By GetUserFieldFallbackBy() => By.Id("userFieldFallback");

    public By GetDefectPluginDropDownListBy() => By.XPath("//div[@id='defect_plugin_chzn' and @class='chzn-container chzn-container-single']");
    public By GetReferencePluginDropDownListBy() => By.XPath("//div[@id='reference_plugin_chzn' and @class='chzn-container chzn-container-single']");

    public By GetAddEditProjectAddButtonBy() => By.XPath("//button[@data-testid='addEditProjectAddButton']");

    public By GetConfigureVariableConfirmationBy() => By.XPath("//button[@data-testid='configureVariableDialogUserFieldOk']");







    public void SelectTab(string TabTitle)

    {


        IWebElement Tab = Driver.FindElement(By.XPath($"//a[@onclick='App.Tabs.activate(this); ' and contains(., '{TabTitle}')]"));
        Tab.Click();

    }






    





    public void SelectFromDropdownList(IWebElement DropDownList, string Text)

    {

        SelectElement dropdown = new SelectElement(DropDownList);

        dropdown.SelectByText(Text);

    }



    public void SelectFromDefectDropdownList(By DropDownListBy, string Text)

    {
        IWebElement DropDownList = Driver.FindElement(DropDownListBy);
        DropDownList.Click();
       IWebElement SelectedOption = Driver.FindElement(By.XPath($"//li[contains(@id, 'defect') and text()='{Text}']"));
       SelectedOption.Click();
    }


    public void SelectFromReferenceDropdownList(By DropDownListBy, string Text)

    {
        IWebElement DropDownList = Driver.FindElement(DropDownListBy);
        DropDownList.Click();
        IWebElement SelectedOption = Driver.FindElement(By.XPath($"//li[contains(@id, 'reference') and text()='{Text}']"));
        SelectedOption.Click();
    }





  






}








