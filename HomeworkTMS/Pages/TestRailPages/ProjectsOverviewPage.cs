using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class ProjectsOverviewPage: BasePage
    {

    private static DateTime currentDate = DateTime.Today;
    private static string formattedDate = currentDate.ToString("dd.MM.yyyy");
    private string _endPoint = "index.php?/admin/projects/overview";


    private static readonly By AddProjectButtonBy = (By.XPath("//a[contains(., 'Add Project')]"));

    private static readonly By MessageSuccessfullyAddedBy = (By.XPath("//div[contains(text(),'Successfully added the new project.')]"));

    private static readonly By ProjectDeleteButtonBy = (By.XPath($"//a[contains(., '{formattedDate}')]/following::div[@data-testid='projectDeleteButton'][1]"));

   
    private static readonly By DeleteCheckboxBy = (By.XPath("//div[@data-testid='caseFieldsTabDeleteDialogCheckbox']/descendant::input[@data-testid='deleteCheckBoxTestId']"));

    private static readonly By ConfirmationDeleteOkBy = (By.XPath("//a[@data-testid='caseFieldsTabDeleteDialogButtonOk']"));

    private static readonly By MessageSuccessfullyDeletedBy = (By.XPath("//div[contains(text(),'Successfully deleted the project.')]"));



    public ProjectsOverviewPage(IWebDriver driver) : base(driver)

    {
        Driver = driver;


    }


    public IWebDriver Driver { get; set; }


    public override string GetEndPoint()

    {
        return _endPoint;
    }


    public IWebElement AddProjectButton() => Driver.FindElement(AddProjectButtonBy);

    public void PressAddProjectButton() => AddProjectButton().Click();

    public void CheckProjectAddition() => new Message(Driver, MessageSuccessfullyAddedBy);


    public Button DeleteProjectButton() => new Button(Driver, ProjectDeleteButtonBy);


    public void PressDeleteProjectButton() => DeleteProjectButton().Click();

    public Checkbox DeleteCheckbox() => new Checkbox(Driver, DeleteCheckboxBy);

    public void SelectDeleteCheckbox() => DeleteCheckbox().Click();

    public Button ConfirmationDeleteOkButton() => new Button(Driver, ConfirmationDeleteOkBy);

    public void SelectConfirmationDeleteOkButton() => ConfirmationDeleteOkButton().Click();


    public Message CheckProjectDeleted() => new Message(Driver, MessageSuccessfullyDeletedBy);



}


