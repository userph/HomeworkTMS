using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class ActionsHelper
    {

    private IWebDriver _driver { get; set; }
    private Actions _actions { get; set; }


    public ActionsHelper(IWebDriver driver)
    {
        _driver = driver;

        _actions = new Actions(_driver);
    }


    public void MoveToElement(IWebElement element) => _actions.MoveToElement(element).Perform();
    public void ContextClick(IWebElement element) => _actions.ContextClick(element).Perform();


}

