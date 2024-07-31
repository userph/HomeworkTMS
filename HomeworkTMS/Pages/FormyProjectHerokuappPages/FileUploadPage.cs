using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


public class FileUploadPage : BasePage
{

    private string _endPoint = "fileupload";







    public FileUploadPage(IWebDriver driver) : base(driver)

    {
        Driver = driver;


    }


    public IWebDriver Driver { get; set; }


    public override string GetEndPoint()

    {
        return _endPoint;
    }


   



    string filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Resources", GetUploadedFileName());
    private static By FileInputButtonBy = By.XPath("//input[@type='file']");
    private static By FileUploadFieldBy = By.XPath("//input[@id='file-upload-field']");

    public IWebElement FileInputButton() => Driver.FindElement(FileInputButtonBy);
    public void UploadFile() => FileInputButton().SendKeys(filePath);

    public IWebElement FileUploadField() => Driver.FindElement(FileUploadFieldBy);

    public string GetActualFileName() => FileUploadField().GetAttribute("value");


    public void CompareFileName(string UploadedFileName, string ActualFileName) => 
        Assert.That(ActualFileName, Is.EqualTo(FileUploadPage.GetUploadedFileName()));




}

