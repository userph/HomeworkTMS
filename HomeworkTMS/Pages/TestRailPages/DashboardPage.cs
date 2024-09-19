using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class DashboardPage : BasePage
{


    private string _endPoint = "/index.php?/dashboard";



    private static readonly By AddProjectButtonBy = By.XPath("//a[@data-testid='sidebarProjectsAddButton']"); 


    public DashboardPage(IWebDriver driver) : base(driver)

    {
        Driver = driver;


    }


    public IWebDriver Driver { get; set; }


    public override string GetEndPoint()

    {
        return _endPoint;
    }


    private IWebElement AddProjectButton() => Driver.FindElement(AddProjectButtonBy);
    public void PressAddProjectButton() => AddProjectButton().Click();

    /*
    private string AddProjectButtonLinkUrl() => AddProjectButton().GetAttribute("href");
    public void PressAddProjectButton() => Driver.Navigate().GoToUrl(AddProjectButtonLinkUrl());


    */


}

