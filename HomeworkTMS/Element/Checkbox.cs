using OpenQA.Selenium;
using System.Collections.ObjectModel;


public class Checkbox
{

  
    private readonly List<UiElement> _uiElements;
    private readonly UiElement _uiElement;


    public Checkbox(IWebDriver driver, IReadOnlyCollection<IWebElement> uiElements)
    {
        _uiElements = uiElements.Select(e => new UiElement(driver, e)).ToList();
    }

    public Checkbox(IWebDriver driver, By locator)
    {
        _uiElement = new UiElement(driver, locator);
    }


    public void CheckQuantity(int Quantity)

    {

        int checkboxCount = _uiElements.Count();
        Assert.That(checkboxCount, Is.EqualTo(Quantity));


    }

    public void ClickByIndex(int Index)

    {
        _uiElements[Index].Click();
    }




    public void CheckboxStatusByIndex(string selectionStatusValue, int Index)


    {
      

        if (selectionStatusValue == "IsСhecked")

        {
            Assert.That(_uiElements[Index].Selected, Is.True);

        }


        else if (selectionStatusValue == "IsUnchecked")
        {
            Assert.That(_uiElements[Index].Selected, Is.False);
        }

        else
        {
            throw new ArgumentException($"Invalid boolean value: {selectionStatusValue}");
        }


    }



    public void Select()
    {
        if (!_uiElement.Selected)
        {
            _uiElement.Click();
        }
    }

    public void Deselect()
    {
        if (_uiElement.Selected)
        {
            _uiElement.Click();
        }
    }
    public bool Displayed => _uiElement.Displayed;
    public bool Enabled => _uiElement.Enabled;
    public string Text => _uiElement.Text;
    public bool Selected => _uiElement.Selected;

    public bool Unselected => !_uiElement.Selected;

    public string GetAttribute(string attributeName) => _uiElement.GetAttribute(attributeName);
    public bool IsChecked()
    {
        if (_uiElement.GetAttribute("checked") == null)
        {
            return false;
        }
        else
        {
            return true;
        }
    
}




    public void CheckboxStatus(string selectionStatusValue)


    {


        if (selectionStatusValue == "IsСhecked")

        {
            Assert.That(_uiElement.Selected, Is.True);

        }


        else if (selectionStatusValue == "IsUnchecked")
        {
            Assert.That(_uiElement.Selected, Is.False);
        }

        else
        {
            throw new ArgumentException($"Invalid boolean value: {selectionStatusValue}");
        }


    }


    public void Click() => _uiElement.Click(); 








}

