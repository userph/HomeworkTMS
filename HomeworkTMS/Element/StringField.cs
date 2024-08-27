using AngleSharp.Dom;
using OpenQA.Selenium;



    public class StringField
    {

    private readonly UiElement _uiElement;

    private static DateTime _currentDateTime = DateTime.Now;
    
    private static string formattedDate = _currentDateTime.ToString("dd.MM.yyyy");

    public StringField(IWebDriver driver, By locator)
    {

        _uiElement = new UiElement(driver, locator);
    
    
    }



    public void SendKeyWithTimeStamp(string Key)

    {


        _uiElement.SendKeys(Key + " (timestamp:" + formattedDate + ")");
    }


    public void SendKey(string Key)

    {


        _uiElement.SendKeys(Key);
    }


}

