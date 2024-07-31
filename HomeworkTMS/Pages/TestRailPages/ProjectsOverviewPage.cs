using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class ProjectsOverviewPage: BasePage
    {


    private string _endPoint = "index.php?/admin/projects/overview";


    private static readonly By AddProjectButtonBy = (By.XPath("//a[contains(., 'Add Project')]"));




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

}


