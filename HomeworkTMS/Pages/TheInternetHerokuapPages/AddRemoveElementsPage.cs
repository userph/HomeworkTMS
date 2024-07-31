using Allure.NUnit.Attributes;
using OpenQA.Selenium;



public class AddRemoveElementsPage : BasePage
{

    private string _endPoint = "add_remove_elements/";
    
    private static readonly By AddButtonBy = By.XPath("//button[text()='Add Element']");
    private static readonly By DeleteButtonBy = By.XPath("//button[text()='Delete']");

    public AddRemoveElementsPage(IWebDriver driver) : base(driver)

    {
        Driver = driver;
    }


    public IWebDriver Driver { get; set; }


    public override string GetEndPoint()

    {
        return _endPoint;
    }







    public IWebElement AddButton() => Driver.FindElement(AddButtonBy);
    public IWebElement DeleteButton() => Driver.FindElement(DeleteButtonBy);
 

    public void GoUrl(string url) => Driver.Navigate().GoToUrl(url);


    public void ClickToAddButton() => AddButton().Click();
    public void ClickToDeleteButton() => DeleteButton().Click();

    public void CheckNumberOfElements(int numberOfElements)

    {

        IReadOnlyCollection<IWebElement> elements = Driver.FindElements(DeleteButtonBy);
        int elementCount = elements.Count();
        Assert.That(numberOfElements, Is.EqualTo(elementCount));

    }






}

