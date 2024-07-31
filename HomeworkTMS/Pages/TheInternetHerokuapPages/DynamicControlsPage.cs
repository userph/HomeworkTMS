using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;
using NLog;


public class DynamicControlsPage : BasePage
{

    private string _endPoint = "dynamic_controls";
    private static readonly By CheckboxBy = By.Id("checkbox");
    private static readonly By RemoveButtonBy = By.XPath("//button[text()='Remove']");
    private static readonly By MessageItsGoneBy = By.XPath("//p[contains(text(), 'gone!')]");

    public DynamicControlsPage(IWebDriver driver) : base(driver)

    {
        Driver = driver;


    }

    public IWebDriver Driver { get; set; }


    public override string GetEndPoint()

    {
        return _endPoint;
    }


    public IWebElement Checkbox() => Driver.FindElement(CheckboxBy);

    public IWebElement RemoveButton() => Driver.FindElement(RemoveButtonBy);




    public void RemoveCheckbox() => RemoveButton().Click();



    


  public By Message()

  {


        return MessageItsGoneBy;



 }







}










