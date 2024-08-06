using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngleSharp.Dom;
using OpenQA.Selenium;



public class Message

{

    private readonly UiElement _uiElement;

    public Message(IWebDriver driver, By locator)
    {
        _uiElement = new UiElement(driver, locator);
    }





}

