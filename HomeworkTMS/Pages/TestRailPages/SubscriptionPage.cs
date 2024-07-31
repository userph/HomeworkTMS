using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class SubscriptionPage:BasePage
    {

    private string _endPoint = "index.php?/admin/subscription";

//    private string ProjectsOverviewEndPoint = "index.php?/admin/projects/overview"; 



    private static readonly By ErrorModalWindowBy = 
        By.XPath("//span[text()='Error' and @id='ui-dialog-title-messageDialog']");

    private static readonly By ConfirmationButtonBy =
        By.XPath("//div[@id='messageDialog']/descendant::a[@class='button button-ok button-left button-positive dialog-action-default']");


  //  private static readonly By AddProjectButtonBy = (By.XPath("//a[contains(., 'Add Project')]"));





    public SubscriptionPage(IWebDriver driver) : base(driver)

    {
        Driver = driver;


    }


    public IWebDriver Driver { get; set; }


    public override string GetEndPoint()

    {
        return _endPoint;
    }


    /*
    public string GetProjectsOverviewEndPoint()

    {
        return ProjectsOverviewEndPoint;
    }

    */


    public By Toto()
    {
        return By.XPath("//span[text()='Error' and @id='ui-dialog-title-messageDialog']");
    }


    public IWebElement ErrorModalWindow() => Driver.FindElement(ErrorModalWindowBy);
    public IWebElement ConfirmationButton() => Driver.FindElement(ConfirmationButtonBy);

 //   public IWebElement AddProjectButton() => Driver.FindElement(AddProjectButtonBy);


    public void PressConfirmationButton() => ConfirmationButton().Click();
//    public void PressAddProjectButton() => AddProjectButton().Click();













}

