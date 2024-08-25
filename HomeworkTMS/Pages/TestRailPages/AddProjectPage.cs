using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V125.DOM;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestRail.Elements;


public class AddProjectPage : LcBasePage
{

    private string _endPoint = "index.php?/admin/projects/add/1";
    public Tab Tab { get; set; }



    public By NameBy =
        By.XPath("//input[@data-testid='addProjectNameInput']");
    private static readonly By AnnouncementBy =
        By.XPath("//textarea[@data-testid='addEditProjectAnnouncement']");
    private static readonly By DefectViewUrlBy =
        By.Id("defect_id_url");
    private static readonly By DefectAddUrlBy =
        By.Id("defect_add_url");
    private static readonly By ReferenceViewUrlBy =
        By.Id("reference_id_url");
    private static readonly By ReferenceAddUrlBy =
        By.Id("reference_add_url");
    private static readonly By UserLabelBy =
        By.Id("userFieldLabel");
    private static readonly By UserDescriptionBy = By.Id("userFieldDesc");

    private static readonly By UserSystemNameBy =
        By.Id("userFieldName");
    private static readonly By UserFallbackBy =
        By.Id("userFieldFallback");

    private static readonly By AccessTabBy = By.Id("projects-tabs-access");


    private static readonly By DefectsTabBy = By.Id("projects-tabs-defects");


    private static readonly By ReferencesTabBy = By.Id("projects-tabs-references");


    private static readonly By UserVariablesBy = By.Id("users-fields-fields");


    private static readonly By AddUserButtonBy = 
        By.XPath("//a[contains(., 'Add User Variable')]");

    private static readonly By ShowAnnouncementBy = By.Name("show_announcement");

    private static readonly By EnableTestCaseApprovalsBy = By.Name("case_statuses_enabled");


    private static readonly By DefaultAccessBy = By.Id("access");


    private static readonly By DefectPluginBy = By.XPath("//div[@id='defect_plugin_chzn' and @class='chzn-container chzn-container-single']");
    private static readonly By ReferencePluginBy = By.XPath("//div[@id='reference_plugin_chzn' and @class='chzn-container chzn-container-single']");
    private static readonly By UserTypeBy = By.Id("userFieldType");


    private static readonly By UseRadioButtonBy = By.XPath("//input[@type='radio' and @name='suite_mode']");

    private static readonly By UsserAcceptButtonBy = By.Id("userFieldSubmit");

    private static readonly By AddProjectButtonBy = By.XPath("//button[@data-testid='addEditProjectAddButton']");







    public StringField Name() => new StringField(Driver, NameBy);
    public StringField Announcement() => new StringField(Driver, AnnouncementBy);
    public StringField DefectViewUrl() => new StringField(Driver, DefectViewUrlBy);
    public StringField DefectAddUrl() => new StringField(Driver, DefectAddUrlBy);
    public StringField ReferenceViewUrl() => new StringField(Driver, ReferenceViewUrlBy);
    public StringField ReferenceAddUrl() => new StringField(Driver, ReferenceAddUrlBy);
    public StringField UserLabel() => new StringField(Driver, UserLabelBy);
    public StringField UserDescription() => new StringField(Driver, UserDescriptionBy);
    public StringField UserSystemName() => new StringField(Driver, UserSystemNameBy);
    public StringField UserFallback() => new StringField(Driver, UserFallbackBy);



    public Tab AccessTab() => new Tab(Driver, AccessTabBy);
    public Tab DefectsTab() => new Tab(Driver, DefectsTabBy);
    public Tab ReferencesTab() => new Tab(Driver, ReferencesTabBy);
    public Tab UserVariables() => new Tab(Driver, UserVariablesBy);


    public Button AddUserButton() => new Button(Driver, AddUserButtonBy);

    public Button AddProjectButton() => new Button(Driver, AddProjectButtonBy);

    public Checkbox ShowAnnouncementCheckbox() => new Checkbox(Driver, ShowAnnouncementBy);
    public Checkbox EnableTestCaseApprovalsCheckbox() => new Checkbox(Driver, EnableTestCaseApprovalsBy);

    public Dropdown DefaultAccess() => new Dropdown(Driver, DefaultAccessBy);
    public Dropdown DefectPlugin() => new Dropdown(Driver, DefectPluginBy);
    public Dropdown ReferencePlugin() => new Dropdown(Driver, ReferencePluginBy);

    public Dropdown UserType() => new Dropdown(Driver, UserTypeBy);

    public RadioButton UseRadioButton() => new RadioButton(Driver, UseRadioButtonBy);

    public Button UserAcceptButton() => new Button(Driver, UsserAcceptButtonBy);



    public AddProjectPage(IWebDriver driver, bool openPageByUrl = false) : base(driver, openPageByUrl)

    {
        Driver = driver;
        if (openPageByUrl)
            Load();

    }


    protected override bool EvaluateLoadedStatus()
    {
        return AddProjectButton().Displayed;
    }


    public override string GetEndPoint()

    {
        return _endPoint;
    }


    public void SelectFromDefectDropdownList(string ReadConfigurationValue)

    {

        DefectPlugin().Click();
        IWebElement SelectedOption = Driver.FindElement(By.XPath($"//li[contains(@id, 'defect') and text()='{ReadConfigurationValue}']"));
        SelectedOption.Click();
    }


    public void SelectFromReferenceDropdownList(string DefectPluginValue)

    {

        ReferencePlugin().Click();
        IWebElement SelectedOption = Driver.FindElement(By.XPath($"//li[contains(@id, 'reference') and text()='{DefectPluginValue}']"));
        SelectedOption.Click();
    }


    public void SelectShowAnnouncementCheckbox(string ShowAnnouncementCheckboxValue)

    {

        if (ShowAnnouncementCheckboxValue == "yes")

            ShowAnnouncementCheckbox().Select();


    }


    public void SelectEnableTestCaseApprovals(string EnableTestCaseApprovalsCheckboxValue)

    {

        if (EnableTestCaseApprovalsCheckboxValue == "yes")
            EnableTestCaseApprovalsCheckbox().Select();


    }







}




