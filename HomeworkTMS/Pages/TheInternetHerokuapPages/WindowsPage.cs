using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class WindowsPage: BasePage
    {

    private string _endPoint = "windows";






    public WindowsPage(IWebDriver driver) : base(driver)

    {
        Driver = driver;


    }

    public IWebDriver Driver { get; set; }


    public override string GetEndPoint()

    {
        return _endPoint;
    }

    private static readonly By newTabButtonBy = By.XPath("//a[text()='Click Here']");

    public IWebElement NewTabButton() => Driver.FindElement(newTabButtonBy);
    public void ClickNewTabButton() => NewTabButton().Click();
    
    public void SwitchToTab(int tabNum) => Driver.SwitchTo().Window(Driver.WindowHandles[tabNum]);

    public void CheckTitle(string titleText) => Assert.That(Driver.FindElement(By.TagName("h3")).Text, Is.EqualTo(titleText));



















}

