using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;



public abstract class BasePage
{


    public string HerokuappDomainURL = Configurator.ReadConfiguration().HerokuappUrl;

    public string DemoqaDomainURL = Configurator.ReadConfiguration().DemoqaUrl;

    public string QacTestRailURL = Configurator.ReadConfiguration().QacTestRailUrl;

    public string FormyProjectHerokuappURL = Configurator.ReadConfiguration().FormyProjectHerokuappUrl;

    public IWebDriver Driver { get; set; }





    public BasePage(IWebDriver driver)

    {

        Driver = driver;

    }





    public abstract string GetEndPoint();


    public string GetHerokuappDomainURL()
    {
        return HerokuappDomainURL;
    }


    public string GetDemoqaDomainURL()
    {
        return DemoqaDomainURL;
    }



    public string GetFormyProjectHerokuappURL()

    { 
        
        return FormyProjectHerokuappURL;
    
    }

    public string GetQacTestRailURL()

    {

        return QacTestRailURL;

    }







    public IAlert SwitchToAlert()
    {
        return Driver.SwitchTo().Alert();
    }



    public void OpenPageByUrl(string domainURL, string endPoint)

    {
        Driver.Navigate().GoToUrl(domainURL + endPoint);
    }



    public static string GetUploadedFileName()

    {

        return Configurator.ReadConfiguration().UploadedFileName;
    }




}