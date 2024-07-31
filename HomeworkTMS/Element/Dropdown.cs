using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;



public class Dropdown
{
    private readonly UiElement _uiElement;
    private readonly SelectElement _dropdownList;

    public Dropdown(IWebDriver driver, By locator)
    {
        _uiElement = new UiElement(driver, locator);

        try
        {
            _dropdownList = new SelectElement(_uiElement);
        }

        catch 
        
        {
            _dropdownList = null;
        }
       
    }










    //выбор значения
    public void SelectByText(string text) => _dropdownList.SelectByText(text);

    public void SelectByIndex(int index) => _dropdownList.SelectByIndex(index);


    public void SelectByValue(string text) => _dropdownList.SelectByValue(text);

    // получение выбранного значения
    public string GetSelectedText() => _dropdownList.SelectedOption.Text;
    public string GetSelectedValue() => _dropdownList.SelectedOption.GetAttribute("value");

    // gроверка наличия элементов в dropdown
    public bool IsDropdownEmpty() => !_dropdownList.Options.Any();
    public int GetDropdownSize() => _dropdownList.Options.Count;

    //
    public void Click() => _uiElement.Click();

}