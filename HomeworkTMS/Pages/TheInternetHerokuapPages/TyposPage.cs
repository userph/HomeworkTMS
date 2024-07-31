using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class TyposPage: BasePage
    {

    private string _endPoint = "typos";
    private static readonly By paragraphElementBy = By.ClassName("example");





    public TyposPage(IWebDriver driver) : base(driver)

    {
        Driver = driver;


    }

    public IWebDriver Driver { get; set; }


    public override string GetEndPoint()

    {
        return _endPoint;
    }


    public IWebElement paragraphElement() => Driver.FindElement(paragraphElementBy);


    public void CheckWrongEntryAbsence(string erroneousEntry)

    {

        Assert.That(paragraphElement().Text.Contains(erroneousEntry), Is.False);


    }







}

