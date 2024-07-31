using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class AlertsPage: BasePage
    {

    private string _endPoint = "alerts";




    private static readonly By AlertButtonBy = By.Id("alertButton");
    private static readonly By TimerAlertButtonBy = By.Id("timerAlertButton");
    private static readonly By ConfirmButtonBy = By.Id("confirmButton");
    private static readonly By PromptButtonBy = By.Id("promtButton");





    public AlertsPage(IWebDriver driver) : base(driver)

    {
        Driver = driver;


    }




    public IWebDriver Driver { get; set; }


    public override string GetEndPoint()

    {
        return _endPoint;
    }

    public IWebElement AlertButton() => Driver.FindElement(AlertButtonBy);
    public IWebElement TimerAlertButton() => Driver.FindElement(TimerAlertButtonBy);
    public IWebElement ConfirmButton() => Driver.FindElement(ConfirmButtonBy);
    public IWebElement PromptButton() => Driver.FindElement(PromptButtonBy);





    public void AlertButtonClick() => AlertButton().Click();
    public void TimerAlertButtonClick() => TimerAlertButton().Click();
    public void ConfirmButtonClick() => ConfirmButton().Click();
    public void PromptButtonClick() => PromptButton().Click();




    

    public void CheckAlertResult(string id, string text)

    {
        string xpath = $"//span[@id='{id}' and contains(., '{text}')]";

        Driver.FindElement(By.XPath(xpath));
    }



    




    




}

