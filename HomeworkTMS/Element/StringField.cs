using AngleSharp.Dom;
using OpenQA.Selenium;



    public class StringField
    {

    private readonly UiElement _uiElement;

    DateTime _currentDateTime = DateTime.Now;

    public StringField(IWebDriver driver, By locator)
    {

        _uiElement = new UiElement(driver, locator);
    
    
    }



    public void SendKeyWithTimeStamp(string Key)

    {


        _uiElement.SendKeys(Key + " (timestamp:" + _currentDateTime + ")");
    }


    public void SendKey(string Key)

    {


        _uiElement.SendKeys(Key);
    }


}

